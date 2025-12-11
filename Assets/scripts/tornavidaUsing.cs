using UnityEngine;

public class tornavidaUsing : MonoBehaviour
{
    public GameObject VentDoor;
    public void tornavidaUse()
    {
        Destroy(VentDoor);
    }
}
