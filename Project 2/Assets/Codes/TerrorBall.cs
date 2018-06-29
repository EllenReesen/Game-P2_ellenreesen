using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrorBall : MonoBehaviour {
	public AudioSource destroysound;
	private float time = 0;
	public float speed = 1, range = 4, beweeg = 6;

	private bool follow = false;

	private GameObject player;

	private float startLight;

	void Start ()
	{
		player = GameObject.Find ("FPSController").gameObject;
		startLight = transform.GetChild (0).GetComponent<Light> ().intensity;
		destroysound = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		//Houdt aantal frames bij
		time += Time.deltaTime;
	
	
		//Afstand naar player 
		float dist = Vector3.Distance (transform.position, player.transform.position);
		if (dist < range) follow = true;

		//Volg de player
		if (follow) 
		{
			transform.position = Vector3.MoveTowards (transform.position, player.transform.position, (beweeg) / 100);
			float rond = Mathf.Abs(15 - Mathf.Clamp (dist, 1, 15));
			//licht intensity
			transform.GetChild(0).GetComponent<Light>().intensity = Mathf.Lerp(transform.GetChild(0).GetComponent<Light>().intensity, rond, Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		//fysieke aanranding
		if (collider.tag == "Player") {
			Application.LoadLevel(Application.loadedLevel);
			destroysound.Play();

	// destroy (gameobject.find ("player"))
		}
	}
}
