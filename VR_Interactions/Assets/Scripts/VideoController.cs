using UnityEngine;
using Valve.VR;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController: MonoBehanviour {
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
        get{ return video.IsPrepared; }
    }

    public bool IsDone {
        get{ return video.isDone; }
    }

    public bool Time {
        get{ return video.time; }
    }

    public ulong Duration {
        get{  return (ulong)(video.frameCount / video.frameRate); }
    }

    public double NTime {
        get{ return Time / Duration; }
    }

    void onEnable() {
        video.errorReceived += errorReceived;
        video.errorReceived += errorReceived;
        video.errorReceived += errorReceived;
        video.errorReceived += errorReceived;
        video.errorReceived += errorReceived;

    }
    void onDisable() {

    }
}