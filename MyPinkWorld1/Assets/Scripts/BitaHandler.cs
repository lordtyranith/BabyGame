using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Linq;
using System;

public class BitaHandler : MonoBehaviour
{
    [SerializeField] Button BitaButton;
    public GameObject Canva1, CanvaVideo;
    public VideoPlayer currentMovie;
    public List <VideoClip> Playlist;
    public float Tempo;
    private void Start()
    {
       RandomIndex();
    }

    public void RandomIndex()
    {
        Playlist = Playlist.OrderBy(tvz => System.Guid.NewGuid()).ToList();
    }

    public void SettingMovie(int bi)
    {
       currentMovie = GameObject.FindGameObjectWithTag("MoviesBita").GetComponent<VideoPlayer>();
        StartCoroutine(PlaylistMount());                         
    }


    IEnumerator PlaylistMount()
    {
        for (int i = 0; i < Playlist.Count; i++)
        {
            currentMovie.clip = Playlist[i];
            currentMovie.Play();
            double time = (currentMovie.clip.length);
            float t = (float)time;
            float timer = Convert.ToSingle(time);
            Tempo = timer;
            yield return new WaitForSeconds(timer);   
        }
    }


    public void BitaPlay()
    {
        // < -- Stop Music --> 
      GameObject obj = GameObject.FindGameObjectWithTag("Musica1");
      AudioSource MusicaFundo1 = obj.GetComponent<AudioSource>();
      MusicaFundo1.Stop();
      //obj.SetActive(false);
       //Destroy(obj);

        Canva1.SetActive(false);
        CanvaVideo.SetActive(true);

    }

}
