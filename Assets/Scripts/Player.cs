using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;

    public Platform CurrentPlatform;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    } 
    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
       AudioSource aidio = GetComponent<AudioSource>();
        aidio.Play();

    }

    public void Die()
    {
        Game.OnPlayerDied();
        ParticleSystem particle = GetComponent<ParticleSystem>();
        particle.Play();
        Rigidbody.velocity = Vector3.zero;
    }

  


}

