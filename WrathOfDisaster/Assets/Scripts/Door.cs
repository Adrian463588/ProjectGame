using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    private CameraController cam;

    private void Awake()
    {
        // Memastikan bahwa CameraController ada dan terhubung
        cam = Camera.main.GetComponent<CameraController>();
        if (cam == null)
        {
            Debug.LogError("CameraController not found on the main camera");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Memeriksa apakah objek yang bertabrakan adalah pemain
        if (collision.CompareTag("Player"))
        {
            if (cam != null)
            {
                // Memeriksa posisi pemain relatif terhadap pintu untuk memilih ruangan yang tepat
                if (collision.transform.position.x < transform.position.x)
                    cam.MoveToNewRoom(nextRoom);
                else
                    cam.MoveToNewRoom(previousRoom);
            }
        }
    }
}