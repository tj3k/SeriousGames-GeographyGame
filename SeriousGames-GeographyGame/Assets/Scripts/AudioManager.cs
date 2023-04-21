using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    [Header("Music/Ambience")]
    public AudioSource[] music, ambience;
    
    [Header("Sound Effects")]
    public AudioSource[] playerSfx, uiSfx;

    private void Awake()
    {
        _instance = this;
    }
    
    [SerializeField] public GameObject player;

    // public void MuteMusicAndAmb()
    // {
    //     if (player.currentHealth < 1)
    //     {
    //         // Stops all Music and Ambience.
    //         music[0].Stop();
    //         amb[0].Stop();
    //         amb[1].Stop();
    //     }
    // 

    void PlayMenuMusic()
    {
        music[0].enabled = true;
    }

    void MuteMenuMusic()
    {
        music[0].enabled = false;
    }
    
    void PlayWorldMusic()
    {
        music[1].enabled = true;
    }
    
    public void MuteWorldMusic()
    {
        music[1].enabled = false;
    }

    void PlayAmbience()
    {
        ambience[0].enabled = true;
        ambience[1].enabled = true;
        ambience[2].enabled = true;
    }

    void MuteAmbience()
    {
        ambience[0].enabled = false;
        ambience[1].enabled = false;
        ambience[2].enabled = false;
    }
    
    public void StopHoverWalkSfx()
    {
        playerSfx[1].pitch = 2.1f;
        playerSfx[0].enabled = false;
        playerSfx[1].enabled = false;
    }
    

}
