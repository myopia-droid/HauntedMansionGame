using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelThreeIntro : MonoBehaviour
{
    public DialogManager DialogManager;

    // Start is called before the first frame update
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("...", "Brother"));
        dialogTexts.Add(new DialogData("...", "Protagonist"));
        dialogTexts.Add(new DialogData("Sorry about my brother, he's just shy. We haven't had a visitor to the sick ward in so long that he's forgotten his manners.", "Sister"));
        dialogTexts.Add(new DialogData("It's no problem. I'm lost, and I heard you guys had a map of the manor", "Protagonist"));
        dialogTexts.Add(new DialogData("Oh, the map... we have it somewhere, I'll look around it for you", "Sister"));
        dialogTexts.Add(new DialogData("Thank you!", "Protagonist"));
        dialogTexts.Add(new DialogData("But while I do so... can you please find my glass eye for me? It should be somewhere around the ward", "Sister"));
        DialogData finalLine = new DialogData("Of course!", "Protagonist");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Level3");
    }

}
