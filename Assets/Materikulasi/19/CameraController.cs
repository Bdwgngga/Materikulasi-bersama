using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ambil objek kamera 1 & 2
    public Camera mainCamera;
    public Camera secondCamera;
    // kamera aktif yang mana
    private Camera activeCamera;
    // ambil objek Player
    public GameObject Player;

    private void Start()
    {
        // set di awal game kalau active camera itu kamera 1
        activeCamera = mainCamera;
    }

    void Update()
    {
        // pindah ke kamera 1 ketika input keyboard = 1
        if (Input.GetKeyDown("1"))
        {
            // set aktif objek kamera 1
            mainCamera.gameObject.SetActive(true);
            // set disable objek kamera 2
            secondCamera.gameObject.SetActive(false);
            // set aktif kamera = kamera 1
            activeCamera = mainCamera;
        }
        // pindah ke kamera 2 ketika input keyboard = 2
        else if (Input.GetKeyDown("2"))
        {
            // set disable kamera 1
            mainCamera.gameObject.SetActive(false);
            // set aktif objek kamera 2
            secondCamera.gameObject.SetActive(true);
            // set aktif kamera = kamera 2
            activeCamera = secondCamera;
        }
        // cek apakah objek player terdaftar di script
        if (Player.gameObject != null)
        {
            // kamera yang aktif, ditransform untuk mengikuti pergerakan objek player
            activeCamera.transform.LookAt(Player.transform);
        }
    }
}
 