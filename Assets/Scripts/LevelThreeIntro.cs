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
        dialogTexts.Add(new DialogData("Sorry about my brother, he’s just shy. We haven’t had a visitor to the sick ward in so long that he’s forgotten his manners.", "Sister"));
        dialogTexts.Add(new DialogData("It’s no problem. I’m lost, and looking for Doctor Edwards’ office.", "Protagonist"));
        dialogTexts.Add(new DialogData("You should go that way. Doctor Edwards won’t be there right now, though - the doctors are making their rounds.", "Sister"));
        dialogTexts.Add(new DialogData("You thank them, but as you turn around and leave:", "Narrator"));
        dialogTexts.Add(new DialogData("Wait! My glass eye - it’s in Doctor Edwards’ office. You could bring it back with you, right?", ""));
        DialogData finalLine = new DialogData("Of course", "Protagonist");

        DialogManager.Show(dialogTexts);

        finalLine.Callback = () => GoToMainScene();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }

}
