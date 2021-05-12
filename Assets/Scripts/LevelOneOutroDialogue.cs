using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelOneOutroDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You found them! Thank you. It's so hard to tell how much time has passed with no ticking of the clock.", "Governess"));
        dialogTexts.Add(new DialogData("You couldn't catch the rabbit? That’s alright, I know his jump has quite a height. But could you do me one more favour?", "Governess"));
        DialogData finalLine = new DialogData("If you see the children… tell them I love them. Take care.", "Governess");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToLevelSelect();

    }

    void GoToLevelSelect()
    {
        SceneManager.LoadScene("Level2Intro");
    }
}
/*
 */