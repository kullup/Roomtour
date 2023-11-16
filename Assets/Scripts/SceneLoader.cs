using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int qualityIndex = 0;

    public void LoadScene(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void switchQuality()
    {
        qualityIndex = (qualityIndex + 1) % QualitySettings.names.Length;
        QualitySettings.SetQualityLevel(qualityIndex, true);
    }
}
