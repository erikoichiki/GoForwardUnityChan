using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudioController : MonoBehaviour {

	AudioSource audioSource;

	// Use this for initialization
	void Start () { 
		
		 audioSource = GetComponent<AudioSource> ();



	}
	
	// Update is called once per frame
	void Update () {
		

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "CubePrefabTag" || other.gameObject.tag=="groundTag") {
		 

			audioSource.PlayOneShot(audioSource.clip);
		}
		}
	
}

