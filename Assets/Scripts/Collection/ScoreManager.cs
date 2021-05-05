using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    double score;
    
    void Start()
    {
        if(instance == null){
            instance= this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(double coinValue){
        score +=coinValue;
        text.text= "X " + score;
    }

    public double getscore()
    {
        return score;
    }
}
