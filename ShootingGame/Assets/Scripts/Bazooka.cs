using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour {

	public GameObject crossHair;
	private AudioSource shootAudioSource;
	public AudioClip shootClip;

    public int roundsShot = 0;
    public int enemiesKilled = 0;

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
        roundsShot++;

        Vector2 dir = crossHair.transform.position;//new Vector2 (crossHair.transform.position.x, crossHair.transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, dir);

        if (hit.collider && hit.collider.gameObject != crossHair)
        {
            enemiesKilled++;
            Destroy(hit.collider.gameObject);
        }

	}
}
