using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSelector : MonoBehaviour
{
    public Button button;
    public string targetSceneString;

    private void Start()
    {
        button.onClick.AddListener(GoToTargetScene);
    }

    public void GoToTargetScene()
    {
        SceneManager.LoadScene(targetSceneString, LoadSceneMode.Single);
    }
}