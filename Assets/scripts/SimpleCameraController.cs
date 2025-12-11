using UnityEngine;
public class SimpleCameraController : MonoBehaviour
{
    public float mouseSensitivity = 3f;
    public Transform target;
    public float distance = 5f;
    
    private float rotationX = 0f;
    private float rotationY = 0f;
    
    void Start()
    {
        // Başlangıçta cursor'u kilitle
        Cursor.lockState = CursorLockMode.Locked;
        
        // Mevcut rotasyonları al
        Vector3 angles = transform.eulerAngles;
        rotationX = angles.y;
        rotationY = angles.x;
    }
    
    void Update()
    {
        // Mouse girdisini al
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        
        // Rotasyonu hesapla
        rotationX += mouseX;
        rotationY -= mouseY;
        
        // Yukarı-aşağı bakışı sınırla
        rotationY = Mathf.Clamp(rotationY, -80f, 80f);
        
        // Rotasyonu uygula
        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        
        // Hedef varsa, mesafeyi koruyarak takip et
        if (target != null)
        {
            Vector3 negDistance = new Vector3(0, 0, -distance);
            Vector3 position = transform.rotation * negDistance + target.position;
            transform.position = position;
        }
    }
}