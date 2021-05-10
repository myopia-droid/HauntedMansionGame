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

        dialogTexts.Add(new DialogData("You brought my eye! Thank you… you can put it on the table there. I’m sorry you couldn’t find your map, but I’m sure you’ll want to get on your way.", "Sister"));
        dialogTexts.Add(new DialogData("The girl looks anxious but you nod and head back towards the elevator. Even without the map, one of the floors of the house must contain an exit, right?", "Narrator"));
        DialogData penultimateLine = new DialogData("...", "Narrator");
        DialogData finalLine = new DialogData("...Run.", "Brother");
        dialogTexts.Add(penultimateLine);
        dialogTexts.Add(finalLine);


        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }

}