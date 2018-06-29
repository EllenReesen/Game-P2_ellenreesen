using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeMenu2 : MonoBehaviour {

	public AudioMixer audiomixer;

	public void VolumeSettins(float volume)
	{
		audiomixer.SetFloat ("volume2", volume);
	}
}
