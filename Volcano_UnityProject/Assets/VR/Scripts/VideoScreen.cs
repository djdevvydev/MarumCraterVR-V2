using UnityEngine;
using System.Collections;

public class VideoScreen : MonoBehaviour {

    [SerializeField]
    int screenNumber;
    [SerializeField]
    string fileToPlay;
    public GameObject playButton;
    public GameObject pauseButton;
    Vector3 currentScale;

    public GameObject trailPoints;

    public MediaPlayerCtrl mediaControlScr;

    Vector3 targetIncreasedScale = new Vector3(22F, 13F, 1.0F);
    Vector3 targetDecreasedScale = new Vector3(0.1F, 0.1F, 0.1F);

    float duration = 3.0F;

    public void GrowVideoScreen()
    {
        //StartCoroutine("FadeIn");
        transform.localScale = targetIncreasedScale;
        trailPoints.SetActive(false);
    }

    public void FadeVideoScreen()
    {
        VideoScreenPause();
        gameObject.SetActive(false);
    }

    IEnumerator FadeOut()
    {
        VideoScreenPause();
        //int scaleFactor = 100;
        //transform.localScale = targetDecreasedScale;
        Debug.Log("Decrease size of screen " + screenNumber);
        float counter = 0.0F;
        while (counter < 1.0F)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetDecreasedScale, counter);
            counter += Time.deltaTime / duration;
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = targetDecreasedScale;
        gameObject.SetActive(false);
    }

    IEnumerator FadeIn()
    {
        //int scaleFactor = 100;
        //Debug.Log("transform.localScale = " + transform.localScale);
        float counter = 0.0F;
        while (counter < 1.0F)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetIncreasedScale, counter);
            counter += Time.deltaTime / duration;
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = targetIncreasedScale;
    }

    //Called by SightControl.cs - used to start playback on the video
    public void VideoScreenPlay()
    {
        SceneManager.instance.audioManager.vrAudioSource.Pause();
        mediaControlScr.Load(fileToPlay);
        mediaControlScr.Play();
        playButton.SetActive(false);
        pauseButton.SetActive(true);
        trailPoints.SetActive(false);
        Debug.Log("Playing video on screen " + screenNumber);
    }

    public void VideoScreenPause()
    {
        Debug.Log("Paused video on screen " + screenNumber);
        trailPoints.SetActive(true);
        mediaControlScr.Pause();
        playButton.SetActive(true);
        pauseButton.SetActive(false);
        //SceneManager.instance.mediaPlayerCtrl.Pause();
    } 
}
