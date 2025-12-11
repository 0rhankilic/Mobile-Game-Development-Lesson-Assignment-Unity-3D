using UnityEngine;
using UnityEngine.UI;

public class itempicktornavida : MonoBehaviour
{
    public Button TornavidaEnv;
    public GameObject tornavida;
    public GameObject tornavidaAl1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "screwdrivercol")
        {
            tornavidaAl1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "screwdrivercol")
        {
            tornavidaAl1.SetActive(false);
        }
    }

    public void tornavidaAl()
    {
        EnvanterSystem.TornavidaAlindiMi = true;
        tornavida.SetActive(false);
        tornavidaAl1.SetActive(false);
        TornavidaEnv.interactable = true;
    }

    
}
