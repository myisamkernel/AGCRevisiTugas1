using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;

    private void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        // di documentation suruh tambahin 1 value tapi tetap null pointer exception
        // https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
        bgmAudioSource.Play(0);
    }
    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
