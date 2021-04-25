using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class TestMessage : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        var line1 = new DialogData("Please find me 17 bitcoin", "Governess");
        var line2 = new DialogData("If you don't I won't be able to move on to the afterlife :(", "Governess");
        var line3 = new DialogData("3", "Governess");
        dialogTexts.Add(line1);
        dialogTexts.Add(line2);
        dialogTexts.Add(line3);

        DialogManager.Show(dialogTexts);

        line3.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main scene");
    }
}
