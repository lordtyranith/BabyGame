using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    SoundController Sounds = new SoundController();

  public void SceneLoader(string SceneName)
  {
        SceneManager.LoadScene(SceneName);
  }
    

  public void LoadWITHNOMusic(string SceneName)
  {
        SceneManager.LoadScene(SceneName);
        Sounds.StopMusic();
  }
}
