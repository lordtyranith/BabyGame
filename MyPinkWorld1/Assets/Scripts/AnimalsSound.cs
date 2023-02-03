using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimalsSound : MonoBehaviour
{
    [SerializeField] AudioSource AnimalSelected;
    private void Start()
    {
        AnimalSelected = this.GetComponent<AudioSource>();
    }

    public void AnimalPlay()
    {
        StartCoroutine(PlayForATime());
    }

    IEnumerator PlayForATime()
    {
        AnimalSelected.Play();
        yield return new WaitForSeconds(3f);
        AnimalSelected.Stop();
    }
}
