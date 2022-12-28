using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Valve.VR;
using UnityEngine.Video;
// using System;

public class PlayPause : MonoBehaviour       
{
    private VideoPlayer video;

    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
    }

    public void PlayVideo()
    {
        video.Play();
        // Console.WriteLine("x is greater than y");

    }
    public void PauseVideo()
    {
        video.Pause();
        // Console.WriteLine("x is greater than y");
    }
}
