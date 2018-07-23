using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject enemyPrefab;
	public Sprite[] enemySprites;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnEnemy", 0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnEnemy() {
		GameObject newGO = (GameObject)Instantiate (enemyPrefab);
		float x = Random.Range (-13.0f, 13.0f);
		newGO.transform.position = new Vector3 (x, -5f, 4f);
		newGO.GetComponent<SpriteRenderer> ().sprite = enemySprites [Random.Range (0, enemySprites.Length)];
		newGO.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 500);
	}
}
