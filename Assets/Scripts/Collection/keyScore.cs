using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyScore : MonoBehaviour
{ 
    public static keyScore instance;
    public TextMeshProUGUI text;
    double score;
    
    void Start()
    {
        if(instance == null){
            instance= this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(double key){
        score +=key;
        text.text= "score";
    }

    public double getscore()
    {
        return score;
    }
}
