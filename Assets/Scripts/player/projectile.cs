using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
  public float speed;
  public float duration;
  public float effectDuration;
  public float distance;
  public int damage;

  public LayerMask solidItems;

  public GameObject playerController;
  private playerController pc;

  private int orientation;

  public GameObject destroyMagic;
  private cameraShake shake;

    // Start is called before the first frame update
    private void Start()
    {
      shake = GameObject.FindGameObjectWithTag("CameraShake").GetComponent<cameraShake>();

      playerController = GameObject.FindWithTag("Player");
      if (playerController != null) {
        pc = playerController.GetComponent<playerController>();
      }

      if (pc.facingRight == true) {
        orientation = 1;
      } else {
        orientation = -1;
      }

      Invoke("destroyProjectile", duration);
    }

    // Update is called once per frame
    private void Update()
    {
      RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, orientation * transform.right, distance, solidItems);
      if (hitInfo.collider != null) {
        if (hitInfo.collider.CompareTag("Enemy")) {
          hitInfo.collider.GetComponent<bodyPartDmg>().takeDamage(damage);
                shake.shake();
        }
        destroyProjectile();
      }

      transform.Translate(orientation * transform.right * speed * Time.deltaTime);
    }

    void destroyProjectile() {
      Instantiate(destroyMagic, transform.position, Quaternion.identity);
      Destroy(gameObject);
    }
}
