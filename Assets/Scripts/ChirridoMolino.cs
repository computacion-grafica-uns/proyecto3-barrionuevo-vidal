using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChirridoMolino : MonoBehaviour
{
     public AudioSource audioSource;             // Asignalo en el Inspector
    public AudioClip[] soundClips;              // Lista de sonidos
    public float minDelay = 1f;                 // Tiempo mínimo entre sonidos
    public float maxDelay = 5f;                 // Tiempo máximo entre sonidos
    private int anterior;
    private void Start()
    {
        anterior = -1;
        StartCoroutine(PlayRandomSounds());
    }

    private IEnumerator PlayRandomSounds()
    {
        while (true)
        {
            float waitTime = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(waitTime);

            int index = Random.Range(0, soundClips.Length);

            while (index == anterior)
            {
                index = Random.Range(0, soundClips.Length);
            }

            anterior = index;
            audioSource.clip = soundClips[index];
            audioSource.Play();
        }
    }
}
