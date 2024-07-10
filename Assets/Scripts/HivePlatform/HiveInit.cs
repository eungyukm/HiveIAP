using hive;
using UnityEngine;

public class HiveInit : MonoBehaviour
{
    private const string CertificationKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJIaXZlIiwiaWF0IjoxNjkwOTU1ODgzLCJqdGkiOiI4OTQ5OTI0MTcifQ.gpRXO1psqWZFFBsg2Uwlmc7S0gCeL-vQYTSCoRk0H_0";
    
    public void Awake()
    {
        HIVEUnityPlugin.InitPlugin();
        Configuration.setHiveCertificationKey(CertificationKey);
        
        Debug.Log("[HIVE] Plugin was initialized.");
    }
}
