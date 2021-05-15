using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadCurrentScene : MonoBehaviour
{
    private Scene scene;
    private string sceneName;
    public GameObject player;
    private playerController playerScript;

    private float health;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        playerScript = player.GetComponent<playerController>();
        health = PlayerPrefs.GetFloat("health");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }

        if (playerScript.health <= 0)
        {
          SceneManager.LoadScene(sceneName);
          PlayerPrefs.DeleteAll();
          PlayerPrefs.SetFloat("health", 20);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("health", health);
    }
}
