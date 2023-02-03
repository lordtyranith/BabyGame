using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    AudioSource BackgroundSound;
    AudioSource ClickEffect;
    AudioSource MagicSound;

    void Start()
    {
        BackgroundSound = GameObject.FindGameObjectWithTag("Musica1").GetComponent<AudioSource>();
        ClickEffect = GameObject.FindGameObjectWithTag("SoundClick").GetComponent<AudioSource>();
        MagicSound = GameObject.FindGameObjectWithTag("MagicSound").GetComponent<AudioSource>();
    }

    public void SoundClick()
    {
        ClickEffect.Play();
    }

    public void MagicPlay()
    {
        MagicSound.Play();
    }

    public void StopMusic()
    {
        
        GameObject obj = GameObject.FindGameObjectWithTag("Musica1");
        AudioSource MusicaFundo1 = obj.GetComponent<AudioSource>();
        BackgroundSound.Stop(); 
        obj.SetActive(false);
        Destroy(obj);
    }



 
    
}
