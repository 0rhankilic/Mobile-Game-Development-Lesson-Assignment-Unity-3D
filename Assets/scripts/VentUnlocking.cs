using UnityEngine;

public class VentUnlocking : MonoBehaviour
{
    public GameObject ventac;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && EnvanterSystem.TornavidaAlindiMi == true)
        {
            ventac.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && EnvanterSystem.TornavidaAlindiMi == true)
        {
            ventac.SetActive(false);
        }
    }

}
