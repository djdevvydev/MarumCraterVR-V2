using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour {

    public Animation credits1;
    public Animation credits2;
    public Animation credits3;

    Animation anim;

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("CreditsAnimation");
	}
	
	IEnumerator CreditsAnimation()
    {
        Debug.Log("Start called.");
        yield return new WaitForSeconds(4);
        Debug.Log("calling Animation.");
        credits2.Play();

        yield return new WaitForSeconds(4);
        Debug.Log("calling Animation.");
        credits3.Play();

        yield return new WaitForSeconds(4);
        Application.LoadLevel(1);
    }
}
