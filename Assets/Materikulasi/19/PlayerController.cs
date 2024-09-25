using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ambil properti karakter controller
    public CharacterController characterController;
    // set kecepatan karakter
    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        // set posisi sumbu x untuk pergerakan kiri/kanan
        float x = Input.GetAxis("Horizontal") * speed;
        // set posisi sumbu z untuk pergerakan depan/belakang
        float z = Input.GetAxis("Vertical") * speed;
        // set arah/direction dari objek karakter akan bergerak sejauh mana
        Vector3 direction = transform.right * x + transform.forward * z;
        // set pergerakan berdasarkan seberapa lama input ditekan
        characterController.Move(direction * Time.deltaTime);
    }
}
