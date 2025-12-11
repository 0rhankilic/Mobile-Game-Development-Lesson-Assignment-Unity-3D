using UnityEngine;

public class kumanda : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ekran;
    public GameObject kumandaUI;

    public void kumandaAc()
    {
        kumandaUI.SetActive(true);
    }
    public void tvAc()
    {
        ekran.SetActive(false);
        kumandaUI.SetActive(false);
    }
}
