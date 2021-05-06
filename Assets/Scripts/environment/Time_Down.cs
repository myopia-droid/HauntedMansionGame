using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Time_Down : MonoBehaviour
{
    int count_down = 100 + 1;
    void Start () {
        GetComponent<UnityEngine.UI.Text> ().text = ""+count_down;
        InvokeRepeating ("Time_count", 0f, 1.0F);
    }

    void Time_count(){ 
        if (count_down > 0) {
        count_down--;
        GetComponent<UnityEngine.UI.Text> ().text = "Remaining time: " + count_down;
        
        } else {
            CancelInvoke ();
            }

        if(count_down<=0){
            SceneManager.LoadScene("PlatForm 2");
        }
    }

}
