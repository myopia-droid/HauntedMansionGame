using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class MessageP2 : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("Girl: Who- who’s there?", "Younggirl");
        var line2 = new DialogData("Sorry, I didn’t mean to scare you. I’ve gotten lost.", "Protagonist");
        var line3 = new DialogData("Oh. Well, m-make sure you’re warm.", "Younggirl");
        var line4 = new DialogData("The fire’s long gone out.", "Younggirl");
        var line5 = new DialogData("You look freezing cold.", "Protagonist");
        var line6 = new DialogData("I have gathered three clothes.", "Younggirl");
        var line7 = new DialogData("But I saw monsters so I dropped them and ran.", "Younggirl");
        var line8 = new DialogData("Clothes were somewhere in non-fiction, I think.", "Younggirl");
        var line9 = new DialogData("But I’ve been too scared to go back.", "Younggirl");
        var line10 = new DialogData("I can go get them for you.", "Protagonist");
        dialogTexts.Add(line1);
        dialogTexts.Add(line2);
        dialogTexts.Add(line3);
        dialogTexts.Add(line4);
        dialogTexts.Add(line5);
        dialogTexts.Add(line6);
        dialogTexts.Add(line7);
        dialogTexts.Add(line8);
        dialogTexts.Add(line9);
        dialogTexts.Add(line10);

        DialogManager.Show(dialogTexts);

        line10.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("PlatForm 2");
    }
}
