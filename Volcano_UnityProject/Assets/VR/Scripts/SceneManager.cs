using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour 
{
    public static SceneManager instance = null;

    public bool narrationEnabled = true;

    [SerializeField]
    //Image fadeOverlay;

    //public bool fading;

    GameObject firstTrailSign;

    public AudioManager audioManager;

    public GameObject[] videoScreens;

    public bool readyForMotionTrack = false;

    public bool cameraFollowPath;

    void Awake()
    {
        if (instance == null)
        {
            //If instance hasn't been set yet, make this object the singleton of "instance"
            instance = this;
        }
        else if (instance != this)
        {
            //If this object is not the singleton of "instance", destroy yourself
            Destroy(gameObject);
        }
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        StartCoroutine("FadeIn");

        
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(5.0F);
        readyForMotionTrack = true;
        videoScreens[audioManager.audioClipIndex].SetActive(true);
        videoScreens[audioManager.audioClipIndex].GetComponent<VideoScreen>().GrowVideoScreen();
        //videoScreens[audioManager.audioClipIndex].GetComponent<VideoScreen>().VideoScreenPlay();
        //Debug.Log("Play video...wait for 5 seconds");
        yield return new WaitForSeconds(30.0F);
        //Debug.Log("Set Trail Points Active*******************************");
        if(audioManager.audioClipIndex == 0)
        {
            videoScreens[audioManager.audioClipIndex].GetComponent<VideoScreen>().trailPoints.SetActive(true);
        }
    }

	
}
