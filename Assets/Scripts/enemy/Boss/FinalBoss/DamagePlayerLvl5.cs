using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerLvl5 : MonoBehaviour

    /*Used with the animation event in final boss's swipe animation*/
{
    public GameObject player;
    public void damagePlayerWithSwipe()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("swipeLeft"))
        {
            if (player.transform.position.x > 0.86) //swipe left is the BOSS'S left, not the left side of the screen
            {
                player.GetComponent<playerController>().health -= 20; //harm
            }

        } else //If the current animation is SWIPE, not SWIPELEFT
        {
            if (player.transform.position.x < 0.86) //if player is on the right
            {
                player.GetComponent<playerController>().health -= 20; //harm
            }
        }


    }
}
