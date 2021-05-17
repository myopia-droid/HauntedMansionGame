using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelThreeOutro : MonoBehaviour
{
    public DialogManager DialogManager;

    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You brought my eye! Thank you... you can put it on the table there.", "Sister"));
        dialogTexts.Add(new DialogData("I'm sorry... I couldn't find the map, but I'm sure you can find your way, you're not far from the exit...","Sister"));
        dialogTexts.Add(new DialogData("The girl looks anxious but you nod and head back towards the elevator. The girl said the exit is near, so it should be fine without the map... right?", "Narrator"));
        DialogData penultimateLine = new DialogData("...", "Protagonist");
        DialogData finalLine = new DialogData("...Run.", "Brother");
        dialogTexts.Add(penultimateLine);
        dialogTexts.Add(finalLine);


        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Level5Intro");
    }

}