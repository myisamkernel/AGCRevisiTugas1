using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    // menyimpan variabel bola sebagai referensi untuk pengecekan
    public Collider bola;

    private void OnCollisionEnter(Collision collision)
    {
        // memastikan yang menabrak adalah bola
        if (collision.collider == bola)
        {
            // kita lakukan debug
            Debug.Log("Kena Bola");
        }
    }
}
