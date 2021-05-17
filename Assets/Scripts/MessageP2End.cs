using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MessageP2End : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You return to records and lay the bolts of fabric at the girl’s feet.", "Narrator"));
        dialogTexts.Add(new DialogData("I’m sorry you had to put yourself at risk for me, when my predicament is my own fault.", "Younggirl"));
        dialogTexts.Add(new DialogData("You see, I ran out of firewood, but I could not bear to use the books as kindling.", "Younggirl"));
        dialogTexts.Add(new DialogData("I have good news, though. According to the library records, a map of the manor was checked out by the twins, they are usually in the sick ward one or two levels above.", "Younggirl"));
        dialogTexts.Add(new DialogData("You should come with me. It’s not safe here.", "Protagonist"));
        dialogTexts.Add(new DialogData("You are a compassionate soul, I can tell. Thank you, but safe or not...", "Younggirl"));
        dialogTexts.Add(new DialogData("I cannot leave the library.", "Younggirl"));
        DialogData finalLine = new DialogData("You left the library alone and entered the elevator again, hopefully the sick ward is on the next level...", "Narrator");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Level3Intro");
    }
}
