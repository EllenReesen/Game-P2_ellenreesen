using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMulti : MonoBehaviour {

	private float time = 0;

	public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time++;

		if (time % 100 == 0 && Random.Range(0, 4) == 2) {
			Instantiate (ball, new Vector3(Random.Range(-50, 50), 2, Random.Range(-130, 80)), Quaternion.identity);

		}
	}
}
