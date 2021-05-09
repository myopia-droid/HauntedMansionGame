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

        var line1 = new DialogData("You return to records and give the girl clothes, she immediately wear them and felt better", "None");
        var line2 = new DialogData("I’m sorry you had to put yourself at risk for me, when\nmy predicament is my own fault.", "Younggirl");
        var line3 = new DialogData("You see, I ran out of firewood, but I could not bear to\nuse the books as kindling.", "Younggirl");
        var line4 = new DialogData("I have good news, though.", "Younggirl");
        var line5 = new DialogData("According to the library records, a map of the manor\nwas checked out by Dr. Edwards.", "Younggirl");
        var line6 = new DialogData("And his office is only one floor above.", "Younggirl");
        var line7 = new DialogData("You should come with me. It’s not safe here.", "Protagonist");
        var line8 = new DialogData("You are a compassionate soul, I can tell.", "Younggirl");
        var line9 = new DialogData("Thank you, but safe or not…", "Younggirl");
        var line10 = new DialogData("I cannot leave the library.", "Younggirl");
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
        //SceneManager.LoadScene("PlatForm 2");
    }
}
