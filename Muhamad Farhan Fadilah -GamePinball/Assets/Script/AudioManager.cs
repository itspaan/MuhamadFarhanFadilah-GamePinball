using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMager : MonoBehaviour
{
    public AudioSource  bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfxAudioSource2;
   private void Start()
	{
		PlayBGM();
	}
	
	public void PlayBGM() 
    { 
        bgmAudioSource.Play();
    }

	public void PlaySFX(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
    
    public void PlaySFX2(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxAudioSource2, spawnPosition, Quaternion.identity);
    }
}
