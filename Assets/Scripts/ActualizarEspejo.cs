using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarEspejo : MonoBehaviour
{
    public Camera mirrorCamera;
    public float updateInterval = 0.5f; // actualizar cada 0.2s

    public int mirrorQualityLevel = 6;
    private int previousQualityLevel;
    private float timer = 0f;

    void Start()
    {
        mirrorCamera.enabled = false; 
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {
            previousQualityLevel = QualitySettings.GetQualityLevel();
            QualitySettings.SetQualityLevel(mirrorQualityLevel, applyExpensiveChanges: false);

            mirrorCamera.Render();

            QualitySettings.SetQualityLevel(previousQualityLevel, applyExpensiveChanges: false);
            timer = 0f;
        }
    }
}
