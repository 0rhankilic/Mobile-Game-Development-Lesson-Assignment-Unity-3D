using UnityEngine;

public class KapiButtonActivation : MonoBehaviour
{
    [Header("Bu kapıya özel buton")]
    public GameObject butonUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Player")&&EnvanterSystem.AnahtarAlindiMi == true)
        {
            Debug.Log($"{gameObject.name}: Oyuncu trigger'a girdi.");
            if (butonUI != null)
            {
                butonUI.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Buton atanmamış!");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            Debug.Log($"{gameObject.name}: Oyuncu trigger'dan çıktı.");
            if (butonUI != null)
            {
                butonUI.SetActive(false);
            }
        }
    }
}


