using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class LevelFourOutroDialogue : MonoBehaviour
{
    public DialogManager DialogManager;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("You take a step off the elevator, but find you cannot take another.", "Narrator"));
        dialogTexts.Add(new DialogData("The darkness clears, revealing those you have met here and a horrifying mess of flesh and machine on the ground.", "Narrator"));
        dialogTexts.Add(new DialogData("I'm sorry we deceived you. Please know we did not of our own volition.", "Governess"));
        dialogTexts.Add(new DialogData("She controls the house, and everything inside.", "Boy"));
        dialogTexts.Add(new DialogData("Including us.", "Girl"));
        dialogTexts.Add(new DialogData("It was part of her plan, to bring you here. She wasn't strong enough to make us solid before, but now...", "Sister"));
        dialogTexts.Add(new DialogData("They solemnly piece together familiar objects.", "Sister"));
        dialogTexts.Add(new DialogData("Gears for movement.", "Sister"));
        dialogTexts.Add(new DialogData("Fabric for a dress.", "Sister"));
        dialogTexts.Add(new DialogData("A glass eye to see.", "Narrator"));
        dialogTexts.Add(new DialogData("A hairpin twisted into a spring.", "Narrator"));
        dialogTexts.Add(new DialogData("The governess takes the key for the elevator from your belt, looking ashamed, and uses it to wind up the doll. It comes alive with a sharp, sickening grin.", "Narrator"));
        dialogTexts.Add(new DialogData("Why do you apologise for making me whole again, my friends? Don't you like it here? We're safe. We're together.", "Doll"));
        dialogTexts.Add(new DialogData("They said you needed them to build yourself. If that's true, let them go now.", "Protagonist"));
        dialogTexts.Add(new DialogData("No! They can't leave me! Papa left me to be with his mistress, and Mama slashed me to ribbons because of it.", "Doll"));
        dialogTexts.Add(new DialogData("Every psychic I've called to me through the veil has left me in a haze of red. I won't be abandoned again. I won't be alone.", "Doll"));
        dialogTexts.Add(new DialogData("You've done this before.", "Protagonist"));
        dialogTexts.Add(new DialogData(" Yes! But none have gotten as far as you. They were slayed by my creations and became' spare parts.", "Doll"));
        dialogTexts.Add(new DialogData("But you're stronger than that. You could stay here, with me. You'd never be lonely again. No one would ever leave you because nobody could.", "Doll"));
        dialogTexts.Add(new DialogData("I'd rather die.", "Protagonist"));
        DialogData finalLine = new DialogData("Suit yourself.", "Doll");
        dialogTexts.Add(finalLine);

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToPlatformer();

    }

    void GoToPlatformer()
    {
        SceneManager.LoadScene("Level5Intro");
    }
}
