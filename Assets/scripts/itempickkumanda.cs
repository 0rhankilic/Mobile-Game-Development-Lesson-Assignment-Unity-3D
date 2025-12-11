using UnityEngine;
using UnityEngine.UI;

public class itempickkumanda : MonoBehaviour
{
    public Button KumandaEnv;
    public GameObject kumanda;
    public GameObject kumandaAl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "tvremote")
        {
           kumandaAl.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "tvremote")
        {
            kumandaAl.SetActive(false);
        }
    }

    public void tornavidaAl()
    {   
        EnvanterSystem.AnahtarAlindiMi = true;
        kumanda.SetActive(false);
        kumandaAl.SetActive(false);
        KumandaEnv.interactable = true;
    }

}
