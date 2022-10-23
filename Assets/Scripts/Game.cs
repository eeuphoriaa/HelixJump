using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Game : MonoBehaviour
{
    public Controls Controls;
    public int Score = 0;
    public GameObject player;
  

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get;private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        ParticleSystem particle = player.GetComponent<ParticleSystem>();
        particle.Play();
        OnParticleSystemStopped();


    }
    void OnParticleSystemStopped()
        {
            ReloadLevel();
        }
    public void OnPlayerReachedFinish()
    {
        if (CurrentState!=State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        LevelIndex++;
        Debug.Log("You won!");
        ReloadLevel();
    }
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }

    }
    private const string LevelIndexKey = "LevelIndex";

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
