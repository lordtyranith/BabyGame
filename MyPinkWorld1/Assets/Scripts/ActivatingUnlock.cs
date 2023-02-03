using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActivatingUnlock : MonoBehaviour
{
    public Button Z, O, E, Exc;
    float timer = 30f;
    public bool MusicRestart = false;   
    public void Activing(int num)
    {
        switch (num)
        {
            case 1:
                O.interactable = true;
                StartCoroutine(TimerReset(timer));
                break;
            case 2:
                E.interactable = true;
                StartCoroutine(TimerReset(timer));
                break;
            case 3:
                Exc.interactable = true;
                StartCoroutine(TimerReset(timer));
                break;
        }
    }


    IEnumerator TimerReset(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        O.interactable = false;
        E.interactable = false;
        Exc.interactable = false;
    }

    public void PressingExc(string Scene)
    {
  
        if (MusicRestart == true) 
        {
            SceneManager.LoadScene(Scene);
            GameObject obj = GameObject.FindGameObjectWithTag("Musica1");
            AudioSource MusicaFundo1 = obj.GetComponent<AudioSource>();
            MusicaFundo1.Play();
     
        }
        else
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
