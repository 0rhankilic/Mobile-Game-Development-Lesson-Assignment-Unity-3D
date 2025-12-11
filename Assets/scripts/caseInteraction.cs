using UnityEngine;

public class caseInteraction : MonoBehaviour
{
    public GameObject kasaAc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kasaAc.SetActive(true);
        }
    }
     private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kasaAc.SetActive(false);
        }
    }
   
}
