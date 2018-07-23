using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour {

	public GameObject crossHair;
	private AudioSource shootAudioSource;
	public AudioClip shootClip;

	// Use this for initialization
	void Start () {
		shootAudioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (crossHair.transform);

		if (Input.GetKeyDown (KeyCode.Space))
			Shoot ();
	}

	private void Shoot() {
		shootAudioSource.PlayOneShot (shootClip);
	}
}
