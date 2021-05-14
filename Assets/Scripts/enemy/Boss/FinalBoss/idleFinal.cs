using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleFinal : StateMachineBehaviour
{
    public float timer;
    private Transform playerPos;
    private GameObject player;

    private bool leftFacing;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 3.5f;
        leftFacing = false;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if player is not dead
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Vector3 Scaler = animator.transform.localScale;

            //flips enemy sprite to current state
            if (leftFacing)
            {
                Scaler.x = -1;
            }
            else
            {
                Scaler.x = 1;
            }

            animator.transform.localScale = Scaler;

            //If time is up, swipe and switch sides for next time boss is idle. Otherwise continue countdown.
            if (timer <= 0)
            {
                animator.SetTrigger("swipe");
                if (leftFacing)
                {
                    leftFacing = false;
                } else
                {
                    leftFacing = true;
                }
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}

    