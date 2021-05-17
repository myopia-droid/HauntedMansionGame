using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      PlayerPrefs.DeleteAll();
      PlayerPrefs.SetFloat("health", 20);
    }
}
