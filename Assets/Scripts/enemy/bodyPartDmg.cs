using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyPartDmg : MonoBehaviour
{
    public GameObject dmg;
    private enemyMechs enemyMechs;

    private bool playerInvul = false;

    private void Start() {
      enemyMechs = dmg.GetComponent<enemyMechs>();
    }

    public void takeDamage(int damage) {
      enemyMechs.health -= damage;
      Debug.Log("got bonked");
    }

    void OnTriggerEnter2D(Collider2D col){
      if (playerInvul == false) {
        if (col.gameObject.tag == "Player") {
          col.GetComponent<playerController>().takeDamage(enemyMechs.damage);
          var player = col.GetComponent<playerController>();
          player.knockbackCount = player.knockbackLength;

          if(col.transform.position.x < transform.position.x) {
            player.knockFromRight = true;
          } else {
            player.knockFromRight = false;
          }
          StartCoroutine(invul());
        }
      }
      Debug.Log("Other Collider:" + col.name);
    }

    IEnumerator invul() {
       playerInvul = true;
       yield return new WaitForSeconds(0.5f);
       playerInvul = false;
    }
}
