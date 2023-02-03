using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public AudioSource MusicaFundo;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        MusicaFundo = GetComponent<AudioSource>();
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (MusicaFundo.isPlaying) return;
        MusicaFundo.Play();
    }

}
