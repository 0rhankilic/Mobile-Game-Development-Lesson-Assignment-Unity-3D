using UnityEngine;
using UnityEngine.UI;

public class itempickanahtar : MonoBehaviour
{
    public Button AnahtarEnv;
    public GameObject anahtar;
    public GameObject anahtarAl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "key")
        {
            anahtarAl.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "key")
        {
            anahtarAl.SetActive(false);
        }
    }

    public void tornavidaAl()
    {   
        EnvanterSystem.AnahtarAlindiMi = true;
        anahtar.SetActive(false);
        anahtarAl.SetActive(false);
        AnahtarEnv.interactable = true;
    }

}
