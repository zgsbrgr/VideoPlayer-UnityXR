using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;
using Unity.XR.PXR;


public class playController : MonoBehaviour {

    public VideoPlayer videoPlayer;
    

    //public VideoClip videoClip;

    
    public Button play;           

    public Sprite playicon;
    public Sprite pauseicon;


    public Button fornt;          
    public Button back;

    private void Awake() 
    {
        // simple function call on PXR_System to check if it succeeds
        var sdk = PXR_System.GetSDKVersion();
        Debug.Log("playController SDK version:" + sdk);
        PXR_System.InitSystemService("Canvas2");
        PXR_System.BindSystemService();
    }
    
    
    private void OnDestory()
    {
        PXR_System.UnBindSystemService();
    }


    private void Start()
    {
        
    }
    /// <summary>
    /// PlayOrPause
    /// </summary>
    public void PlayOrPause()
    {
        if (videoPlayer.isPlaying==true)
        {
            videoPlayer.Pause();
            
            play.GetComponent<Image>().sprite = playicon;
        }
        else
        {
            videoPlayer.Play();
            play.GetComponent<Image>().sprite = pauseicon;
        }
    }

    /// <summary>
    /// fornt
    /// </summary>
    public void Fornt()
    {
        videoPlayer.time += 10f;
    }
    /// <summary>
    /// back
    /// </summary>
    public void Back()
    {
        videoPlayer.time -= 10f;
    }
    
    public void toBServiceBind(string s) {
        Debug.Log("playController Bind success."); 
        PXR_System.PropertySetScreenOffDelay(ScreenOffDelayTimeEnum.NEVER,null);
    }


}
