using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vfxSource;


    public void PlayVFX(Vector3 spawnPosition)
    {
        // spawn vfx pada posisi sesuai parameter
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
}
