using System;
using System.Collections.Concurrent;
using UnityEngine;

public class MainThreadDispatcher : MonoBehaviour
{
    private static readonly ConcurrentQueue<Action> Queue = new();
    
    public static void Enqueue(Action action)
    {
        Queue.Enqueue(action);
    }
    
    private void Update()
    {
        // 업데이트 한번당 하나씩 작업
        if (false == Queue.TryDequeue(out var action))
        {
            return;
        }
        
        action();
    }
}