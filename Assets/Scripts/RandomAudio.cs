using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    public AudioSource audioSource;         
    public float minDelay = 1f;              
    public float maxDelay = 5f;              

    public void OnEnable()
    {
        StartCoroutine(PlaySoundRandomly());
    }

    private IEnumerator PlaySoundRandomly()
    {
        while (true)
        {
            float waitTime = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(waitTime);
            audioSource.Play();
        }
    }
}
