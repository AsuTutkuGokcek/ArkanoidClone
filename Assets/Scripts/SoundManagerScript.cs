using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip gameTheme;
    public static AudioClip ball_block;
    public static AudioClip ball_racket;
    public static AudioClip ball_wall;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        gameTheme = Resources.Load<AudioClip>("1. Track 1");
        ball_block = Resources.Load<AudioClip>("ball_block");
        ball_racket = Resources.Load<AudioClip>("ball_racket");
        ball_wall = Resources.Load<AudioClip>("ball_wall");
        audioSrc = GetComponent<AudioSource>();

        audioSrc.PlayOneShot(gameTheme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        if(clip == "ball_block"){
            audioSrc.PlayOneShot(ball_block);
        }
        if(clip == "ball_racket"){
            audioSrc.PlayOneShot(ball_racket);
        }
        if(clip == "ball_wall"){
            audioSrc.PlayOneShot(ball_wall);
        }
    }
}
