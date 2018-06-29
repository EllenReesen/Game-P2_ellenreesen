using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	private float time;
	private float speed = 1, amplitude = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		//zweefeffect
		transform.position = new Vector3 (transform.position.x, transform.position.y + Mathf.Sin(time * speed) * (amplitude / 150), transform.position.z);
	}
}
