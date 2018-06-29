using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumemenu : MonoBehaviour {


	public AudioMixer audioMixer;

	public void VolumeSetitings(float volume)
	{
		audioMixer.SetFloat ("Volume", volume);
	}
}
	