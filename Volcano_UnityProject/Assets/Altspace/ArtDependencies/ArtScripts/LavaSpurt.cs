using UnityEngine;
using System.Collections;

public class LavaSpurt : MonoBehaviour {

	public ParticleSystem myParticles;


	// Use this for initialization
	void Awake () 
	{
		myParticles = GetComponent<ParticleSystem>();
	}

	void SpewLava()
	{
		myParticles.enableEmission = true;
	}

	void StopLava()
	{
		myParticles.enableEmission = false;
	}
	// Update is called once per frame
	void Update () 
	{
		/*if (Input.GetKeyUp (KeyCode.Space))
		{
			SpewLava();
		}*/
	}
}
