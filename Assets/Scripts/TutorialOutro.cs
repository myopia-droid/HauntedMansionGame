using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialOutro : MonoBehaviour
{
    public DialogManager DialogManager;
 
    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        DialogData finalLine = new DialogData("You find your way back to the elevator and cautiously press one one the elevator panel. Even if not on this floor, you'll find your way out one way or another.", "Narrator");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToSceneOne();

    }

    void GoToSceneOne()
    {
        SceneManager.LoadScene("Level1Intro");
        PlayerPrefs.DeleteAll();
    }
}