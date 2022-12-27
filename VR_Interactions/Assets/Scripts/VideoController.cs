using UnityEngine;
using Valve.VR;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController: MonoBehaviour {
    public VideoPlayer video;
    public Slider slider;

    //properties of the video player
    bool isDone;

    public bool IsPlaying {
        get{ return video.isPlaying; }
    }

    public bool IsLooping {
        get{ return video.isLooping; }
    }

    public bool IsPrepared {
        get{ return video.isPrepared; }
    }

    public bool IsDone {
        get{ return isDone; }
    }

    public bool Time {
        get{ video.time; }
    }

    public ulong Duration {
        get{  return (ulong)(video.frameCount / video.frameRate); }
    }

    public double NTime {
        get{ return Time / Duration; }
    }

    void onEnable() {
        video.errorReceived += errorReceived;
        video.frameReady += frameReady;
        video.loopPointReached += loopPointReached;
        video.prepareCompleted += prepareCompleted;
        video.seekCompleted += seekCompleted;
        video.started += started;

    }
    void onDisable() {
        video.errorReceived -= errorReceived;
        video.frameReady -= frameReady;
        video.loopPointReached -= loopPointReached;
        video.prepareCompleted -= prepareCompleted;
        video.seekCompleted -= seekCompleted;
        video.started -= started;

    }
    
    void errorReceived(VideoPlayer v, string msg) {

        Debug.Log("video player error:" +msg);
        isDone = true;
    }

    void frameReady(VideoPlayer v, long frame) {

        // Debug.Log("video player finished preparing");
        // isDone = false;

    }

    void loopPointReached(VideoPlayer v) {

        Debug.Log("video player loop point reached");
        isDone = true;

    }

    void prepareCompleted(VideoPlayer v) {

        Debug.Log("video player finished preparing");
        isDone = false;

    }

        void seekCompleted(VideoPlayer v) {

        Debug.Log("video player finished seeking");
        isDone = false;

    }
}