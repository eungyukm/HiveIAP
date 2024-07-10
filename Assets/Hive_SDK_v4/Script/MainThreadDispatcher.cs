using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;	// for 	custom UnitySendMessage implement
using AOT;


namespace hive {
    class MainThreadDispatcher : MonoBehaviour {
		void Update() {
			updateExecutionQueue();
		}


		// 동시성 보장 기능 (main thread 에서 호출하기 위함)
		// Code for MainThread Queue
		private static readonly Queue<Action> _executionQueue = new Queue<Action>();

		// 호출 동기화 MonoBehaviour의 update에서 호출 필요.
		void updateExecutionQueue() {
			lock(_executionQueue) {
				while (_executionQueue.Count > 0) {
					_executionQueue.Dequeue().Invoke();
				}
			}
		}

		/// <summary>
		/// Locks the queue and adds the IEnumerator to the queue
		/// </summary>
		/// <param name="action">IEnumerator function that will be executed from the main thread.</param>
		public void Enqueue(IEnumerator action) {
			lock (_executionQueue) {
				_executionQueue.Enqueue (() => {
					StartCoroutine (action);
				});
			}
		}

		/// <summary>
		/// Locks the queue and adds the Action to the queue
		/// </summary>
		/// <param name="action">function that will be executed from the main thread.</param>
		public void Enqueue(Action action)
		{
			Enqueue(ActionWrapper(action));
		}
		
		/// <summary>
		/// Locks the queue and adds the Action to the queue, returning a Task which is completed when the action completes
		/// </summary>
		/// <param name="action">function that will be executed from the main thread.</param>
		/// <returns>A Task that can be awaited until the action completes</returns>
		public Task EnqueueAsync(Action action)
		{
			var tcs = new TaskCompletionSource<bool>();

			void WrappedAction() {
				try 
				{
					action();
					tcs.TrySetResult(true);
				} catch (Exception ex) 
				{
					tcs.TrySetException(ex);
				}
			}

			Enqueue(ActionWrapper(WrappedAction));
			return tcs.Task;
		}

		
		IEnumerator ActionWrapper(Action a)
		{
			a();
			yield return null;
		}

    }
}