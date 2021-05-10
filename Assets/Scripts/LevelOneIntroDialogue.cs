using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelOneIntroDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You pound every button on the panel, but the elevator only seems to want to go up one floor at a time.", "NarratorAfterProtagonist"));
        dialogTexts.Add(new DialogData("Oh my, you've gotten the elevator working again! Welcome to the nursery, I�m the governess here.", "Governess"));
        dialogTexts.Add(new DialogData("The children haven't been able to come down since the elevator broke, I haven;t seen them in... so long...", "Governess"));
        dialogTexts.Add(new DialogData("She takes a moment to compose herself.", "NarratorAfterGoverness"));
        dialogTexts.Add(new DialogData("Say, if you got the elevator working again, maybe you could help me fix the grandfather clock. As far as I can tell, there are a few gears missing.", "Governess"));
        dialogTexts.Add(new DialogData("I�ll do my best.", "Protagonist"));
        DialogData finalLine = new DialogData("Oh, and if you could, be on the lookout for the children�s rabbit! He�s slipped away from me again, but he should be around here somewhere.", "Governess");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToPlatformer();

    }

    void GoToPlatformer()
    {
        SceneManager.LoadScene("Main scene");
    }
}
