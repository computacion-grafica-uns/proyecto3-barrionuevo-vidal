using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickLight : MonoBehaviour
{
    public Light lightSource;
    public float flickerDuration = 0.1f;
    public float flickerInterval = 0.05f;

    private void Start()
    {
        lightSource = GetComponent<Light>();
        StartCoroutine(FlickerLight());
    }

    private IEnumerator FlickerLight()
    {
        float elapsedTime = 0f;

        while (elapsedTime < flickerDuration)
        {
            lightSource.enabled = !lightSource.enabled;
            elapsedTime += flickerInterval;
            yield return new WaitForSeconds(flickerInterval);
        }

        lightSource.enabled = true; // Ensure the light is on after flickering

        StartCoroutine(FlickerLight()); // Restart flickering
    }
}
