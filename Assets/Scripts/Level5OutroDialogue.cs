using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class Level5OutroDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("She's gone...", "Sister"));
        dialogTexts.Add(new DialogData("You've freed us from her control. Thank you.", "Governess"));
        dialogTexts.Add(new DialogData("The monster... gone...", "Brother"));
        dialogTexts.Add(new DialogData("How can you say that? She was our friend once!", "Girl"));
        dialogTexts.Add(new DialogData("Our friend died along with her mother's sanity. That was a machine of resentment and death.", "Boy"));
        dialogTexts.Add(new DialogData("Children, stop that. Let's... let's go home.", "Governess"));
        dialogTexts.Add(new DialogData("They fade away.", "Narrator"));
        dialogTexts.Add(new DialogData("You hear the elevator ding behind you and turn around to see the doors open.", "Narrator"));
        dialogTexts.Add(new DialogData("You step inside, smiling as the elevator doors close behind you one final time.", "Narrator"));
        DialogData finalLine = new DialogData("FIN.", "Narrator");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);


    }
}
