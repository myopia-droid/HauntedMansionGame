using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelFourLetter : MonoBehaviour
{
    public DialogManager DialogManager;
    private float health;

    void Start() {
      health = PlayerPrefs.GetFloat("health");
    }

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("I've failed...", "Letter"));
        dialogTexts.Add(new DialogData("I could not save her from her mother...", "Letter"));
        dialogTexts.Add(new DialogData("and I could not save him from her.", "Letter"));
        dialogTexts.Add(new DialogData("Please, if anyone finds this...", "Letter"));
        DialogData finalLine = new DialogData("Do what I could not and protect my son...", "Letter");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToPlatformer();

    }

    void GoToPlatformer()
    {
        SceneManager.LoadScene("Level3Outro");
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("health", health);
    }
}
