using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Inst { get; set; }
    
    public void Awake()
    {
        if (Inst != null)
        {
            Destroy(gameObject);
            return;
        }

        Inst = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ForceUpdateCanvas()
    {
        StartCoroutine(ForceUpdateCanvasCoroutine());
    }

    private IEnumerator ForceUpdateCanvasCoroutine()
    {
        yield return new WaitForSeconds(1);
        Canvas.ForceUpdateCanvases();
    }
}
