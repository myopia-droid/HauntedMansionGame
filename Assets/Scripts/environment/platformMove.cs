using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    float dirX, moveSpeed = 2f;
	bool moveRight = true;

	// Update is called once per frame
	void Update () {
		if (transform.position.x > 7f)
			moveRight = false;
		if (transform.position.x < 3.25f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}

