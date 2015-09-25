using UnityEngine;
using System.Collections;

public class RandomizeBlobStart : MonoBehaviour {
	public int startDelay;
	private Animator myAnim;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator>();
		startDelay = Random.Range(0, 20);

		StartCoroutine(WaitItOut());
	
	}
	IEnumerator WaitItOut() {
		//print(Time.time);
		yield return new WaitForSeconds(startDelay);
		//print(Time.time);
		myAnim.enabled = true;
	}

}
