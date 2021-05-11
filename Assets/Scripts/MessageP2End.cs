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
        dialogTexts.Add(new DialogData("I’m sorry you had to put yourself at risk for me, when\nmy predicament is my own fault.", "Younggirl"));
        dialogTexts.Add(new DialogData("You see, I ran out of firewood, but I could not bear to\nuse the books as kindling.", "Younggirl"));
        dialogTexts.Add(new DialogData("I have good news, though. According to the library\nrecords, a map of the manor was checked out by\nDr. Edwards, and his office is only one floor above.", "Younggirl"));
        dialogTexts.Add(new DialogData("You should come with me. It’s not safe here.", "Protagonist"));
        dialogTexts.Add(new DialogData("You are a compassionate soul, I can tell. Thank you,\nbut safe or not…", "Younggirl"));
        DialogData finalLine = new DialogData("I cannot leave the library.", "Younggirl");

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
