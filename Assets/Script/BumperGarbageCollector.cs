using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperGarbageCollector : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // kita langsung hapus game objectnya setelah 1 detik
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
