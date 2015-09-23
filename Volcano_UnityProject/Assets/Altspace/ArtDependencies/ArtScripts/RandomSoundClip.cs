﻿using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class RandomSoundClip : MonoBehaviour {

	public AudioSource src;
	public float delayMin = 2;
	public float delayMax = 10;
	public AudioClip[] ac = new AudioClip[6];
	// keep track of which clip played, so it doesn't repeat
	private int prevIndex = 1;
	// Use this for initialization
	void Start () {
		src = GetComponent<AudioSource>();
		src.loop = false;
		src.clip = null;
		src.playOnAwake = false;
		StartCoroutine(PlaySound());
	}
	
	// Update is called once per frame
	IEnumerator PlaySound(){
		while(true){
			if(src){
				if(src.isPlaying && clipLength() == 0){
					src.Stop();
					src.clip = null;
				}
				else if(clipLength() > 0){
					int length = ac.Length;
					int index = 0;
					if(clipLength() > 1){
						do{
							index = Random.Range(0, length);
						}
						while (!ac[index] || index == prevIndex);
					}
					prevIndex = index;
					src.clip = ac[index];
					src.Play();
					float waitTime = Random.Range(delayMin, delayMax);
					yield return new WaitForSeconds(waitTime);
				}
			}
		}
	}

	public int clipLength(){
		int count = 0;
		for(int i = 0; i < ac.Length; i++){
			if(ac[i])
				count++;
		}
		return count;
	}
}
