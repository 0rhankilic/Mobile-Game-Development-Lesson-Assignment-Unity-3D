using UnityEngine;

public class VentCheck : MonoBehaviour
{
    public GameObject Cam;
    public Transform CamDown;
    public Transform CamNormal;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            Cam.transform.position = CamDown.position;
            Debug.Log("kamera collidera girdi");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            Cam.transform.position = CamNormal.position;

        }
    }

    
}
