using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OBBInstaller : MonoBehaviour {

    public GameObject loaderScene;

    public Text loaderText;
	// Use this for initialization
	void Awake()
    {
        GooglePlayDownloader.FetchOBB();
        StartCoroutine("LoadOBBAndLevel");
        StartCoroutine("LoadingWait");
    }

    IEnumerator LoadOBBAndLevel()
    {
        AsyncOperation async = Application.LoadLevelAsync("Volcano");
        yield return async;
        StopAllCoroutines();
        Destroy(loaderScene);
    }

    IEnumerator LoadingWait()
    {
        int counter = 0;
        while(counter < 100)
        {
            loaderText.text = "Loading";
            yield return new WaitForSeconds(0.5f);
            loaderText.text = "Loading.";
            yield return new WaitForSeconds(0.5f);
            loaderText.text = "Loading..";
            yield return new WaitForSeconds(0.5f);
            loaderText.text = "Loading...";
            yield return new WaitForSeconds(0.5f);
            loaderText.text = "Loading..";
            yield return new WaitForSeconds(0.5f);
            loaderText.text = "Loading.";
            yield return new WaitForSeconds(0.5f);
            counter++;
        }
    }
}
