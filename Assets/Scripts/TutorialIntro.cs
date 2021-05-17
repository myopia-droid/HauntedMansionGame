using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialIntro : MonoBehaviour
{
    public DialogManager DialogManager;
    public Image bg;
    public Sprite openDoorSprite;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("...Huh?", "Narrator"));
        dialogTexts.Add(new DialogData("How did you get here? You've never seen this elevator before, let alone boarded it. But somehow you're here. And it's going up.", "Narrator"));
        //dialogTexts.Add(new DialogData("You could be working, but you haven't picked up any exorcism jobs for a while - it's mostly just seances and tarot cards these days - so why are you here?", "Narrator"));
        DialogData openDoorTrigger = new DialogData("You could be working, but you haven't picked up any exorcism jobs for a while - it's mostly just seances and tarot cards these days - so why are you here?", "Narrator");
        dialogTexts.Add(openDoorTrigger);
        dialogTexts.Add(new DialogData("", "Narrator"));
        openDoorTrigger.Callback = () => openDoors();
        dialogTexts.Add(new DialogData("Hello?", "Protagonist"));
        dialogTexts.Add(new DialogData("Something thuds heavily in the dark. You clench your fists, and realise there's a lantern dangling from your hand.", "Narrator"));
        dialogTexts.Add(new DialogData("You swing it out in front of you but all you see is cracked stone and spiderwebs.", "Narrator"));
        DialogData finalLine = new DialogData("You turn back to the elevator, but it has closed behind you and the call button is unresponsive. There's nothing else to do - you'll have to venture into the dark.", "Narrator");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToTutorial();

    }

    void openDoors()
    {
        bg.sprite = openDoorSprite;
    }

    void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        PlayerPrefs.DeleteAll();
    }
}
