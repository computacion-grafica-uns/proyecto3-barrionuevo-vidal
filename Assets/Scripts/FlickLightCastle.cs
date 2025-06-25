using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickLightCastle : MonoBehaviour
{
    public Material materialCastillo;
    public float flickerDuration = 0.1f;
    public float flickerInterval = 0.05f;

    private void Start()
    {
        StartCoroutine(FlickerLight());
    }

    private IEnumerator FlickerLight()
    {
        
        bool isOn = materialCastillo.IsKeywordEnabled("_EMISSION");
        float elapsedTime = 0f;

        while (elapsedTime < flickerDuration)
        {
            if (isOn)
            {
                materialCastillo.SetColor("_EmissionColor", Color.black);
                materialCastillo.DisableKeyword("_EMISSION");
            }
            else
            {
                materialCastillo.SetColor("_EmissionColor", Color.white);
                materialCastillo.EnableKeyword("_EMISSION");
            }

            elapsedTime += flickerInterval;
            yield return new WaitForSeconds(flickerInterval);
        }

        StartCoroutine(FlickerLight()); // Restart flickering
    }
}
