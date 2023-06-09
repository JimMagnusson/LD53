using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public int GetCurrentSceneIndex() {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public int GetSceneCount() {
        return SceneManager.sceneCountInBuildSettings;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadSceneWithBuildIndex(int buildindex)
    {
        SceneManager.LoadScene(buildindex);
    }
}