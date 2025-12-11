using UnityEngine;
using UnityEngine.UI;

public class EnvanterSystem : MonoBehaviour
{
    public static bool TornavidaAlindiMi = false;
    public static bool NotAlindiMi = false;
    public static bool AnahtarAlindiMi = false;
    public static bool KumandaAlindiMi = false;
    public GameObject tornavidaEnv;
    public GameObject kumandaEnv;
    public GameObject anahtarEnv;
    public GameObject notEnv;
    public GameObject Envanter;

    public Text bilgiYazisi;

    public void EnvanterBTN()
    {
        if (Envanter.activeSelf == true)
        {
            Envanter.SetActive(false);
        }
        else
        {
            Envanter.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        if (AnahtarAlindiMi == true)
        {
            anahtarEnv.SetActive(true);
        }
        if (TornavidaAlindiMi == true)
        {
            tornavidaEnv.SetActive(true);
        }
        if (NotAlindiMi == true)
        {
            notEnv.SetActive(true);
        }
        if (KumandaAlindiMi == true)
        {
            kumandaEnv.SetActive(true);
        }
    }
    public void yonlendirme1()
    {
        bilgiYazisi.text = "Anahtarı Bul";
    }
    public void yonlendirme2()
    {
        bilgiYazisi.text = "Kasayı Bul";
    }
    public void yonlendirme3()
    {
        bilgiYazisi.text = "Tornavidayı Bul";
    }
    public void yonlendirme4()
    {
        bilgiYazisi.text = "Havalandırmayı bulup evden kaç";
    }
    
}
