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
        dialogTexts.Add(new DialogData("You shiver, wishing you had a thick coat as the room feels like a stone icebox instead of a- library?", "Narrator"));
        dialogTexts.Add(new DialogData("Squinting in the dark, you miss the table in front of you until you walk right into it.", "Narrator"));
        dialogTexts.Add(new DialogData("Who- who's there?", "Younggirl"));
        dialogTexts.Add(new DialogData("Sorry, I didn't mean to scare you. I've gotten lost.", "Protagonist"));
        dialogTexts.Add(new DialogData("Oh. Well, m-make sure you're warm. The fire's long gone out.", "Younggirl"));
        dialogTexts.Add(new DialogData("You look freezing cold. Aren't there any blankets I could get you?", "Protagonist"));
        dialogTexts.Add(new DialogData("I gathered some bolts of curtain fabric to stitch into a coat, but I saw a spider so I dropped them and ran.", "Younggirl"));
        dialogTexts.Add(new DialogData("T-that was somewhere in non-fiction, I think, but I've been too scared to go back.", "Younggirl"));
        dialogTexts.Add(new DialogData("I can go get them for you.", "Protagonist"));
        dialogTexts.Add(new DialogData("That's very kind of you. You said y-you were lost, did you not?", "Younggirl"));
        DialogData finalLine = new DialogData("This is the records section, so I can try to find a map of the manor for you. Good journey, traveller.", "Younggirl");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);
        
        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("PlatForm 2");
    }
}
