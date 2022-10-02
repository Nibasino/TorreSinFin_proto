using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadsceneController : MonoBehaviour
{

    public string sceneName = "";

    public void LoadScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogError($"No scene name provided");
            return;
        }
        LoadSceneName(sceneName);

    }

    private void LoadSceneName(string name)
    {
        SceneManager.LoadScene(name);

    }
   
   
}
