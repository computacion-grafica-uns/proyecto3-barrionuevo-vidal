using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLigth : MonoBehaviour
{
    public float intensityMin = 0.5f;
    public float intensityMax = 2.0f;
    public float velocity = 2.0f;

    private Light luz;
    private float target;

    void Start()
    {
        luz = GetComponent<Light>();
        target = Random.Range(intensityMin, intensityMax);
    }

    void Update()
    {
        luz.intensity = Mathf.Lerp(luz.intensity, target, Time.deltaTime * velocity);

        // Si está cerca del objetivo, elige uno nuevo
        if (Mathf.Abs(luz.intensity - target) < 0.05f)
        {
            target = Random.Range(intensityMin, intensityMax);
        }
    }
}
