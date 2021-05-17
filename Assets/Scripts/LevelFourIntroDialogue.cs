using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelFourIntroDialogue : MonoBehaviour
{
    public DialogManager DialogManager;
    private float health;

    void Start() {
      health = PlayerPrefs.GetFloat("health");
    }

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You get off the elevator and find that your lantern is running out of fuel. It is getting harder to see.", "Narrator"));
        dialogTexts.Add(new DialogData("Hmm... this doesn't seem like the medical ward...", "Protagonist"));
        dialogTexts.Add(new DialogData("P-please could you help me? I can not find my mother.", "Narrator"));
        dialogTexts.Add(new DialogData("You peered into the dark to see a little boy...", "Narrator"));
        dialogTexts.Add(new DialogData("Are you lost?", "Protagonist"));
        dialogTexts.Add(new DialogData("Mother and I got separated. We were on our way to the\nconservatory when I saw a beetle and let go of her hand to\npick it up.", "Boy"));
        dialogTexts.Add(new DialogData("Now I don't know where she is, and I do not want to walk the\nhalls without her.", "Boy"));
        dialogTexts.Add(new DialogData("How about I see if I can find her? You said the two of you were going to the conservatory?", "Protagonist"));
        dialogTexts.Add(new DialogData("Yes! Mother is an accomplished pianist. You'll know it is her\nby the hairpin Father gave her - gold with a blue flower.", "Boy"));
        dialogTexts.Add(new DialogData("But you'll have to find the ONE real key to the conservatory\nfirst.", "Boy"));
        DialogData finalLine = new DialogData("Please hurry - I know she must be worried sick about me.", "Boy");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToPlatformer();

    }

    void GoToPlatformer()
    {
        SceneManager.LoadScene("Level4Main");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("health", health);
    }
}
