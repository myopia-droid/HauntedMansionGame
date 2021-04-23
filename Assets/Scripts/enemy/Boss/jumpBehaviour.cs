using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBehaviour : StateMachineBehaviour
{
  public float timer;
  public float minTime;
  public float maxTime;

  private Transform playerPos;
  public float speed;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
      if (GameObject.FindGameObjectWithTag("Player") != null) {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      }
      timer = Random.Range(minTime, maxTime);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (playerPos != null) { //if player is not dead move towards player
          if (timer <= 0) {
            animator.SetTrigger("idle");
          } else {
            timer -= Time.deltaTime;
          }

          Vector2 target = new Vector2(playerPos.position.x, animator.transform.position.y);
          Vector3 Scaler = animator.transform.localScale;

          //flips enemy sprite
          if (playerPos.position.x - animator.transform.position.x >= 0) {
            Scaler.x = -1;
          } else {
            Scaler.x = 1;
          }
          animator.transform.localScale = Scaler;

          //moves enemy towards player
          if (Vector2.Distance(animator.transform.position, target) > 1) {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, target, speed * Time.deltaTime);
          }
      } else { //else if player dead return to idle animation
          animator.SetTrigger("idle");
      }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

    }
}
