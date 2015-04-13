using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// generate a ray before shooting a raycast
		Ray mouseCursorRay = Camera.main.ScreenPointToRay ( Input.mousePosition );

		RaycastHit rayCastDestination = new RaycastHit ();

		if ( Physics.Raycast ( mouseCursorRay, out rayCastDestination, 1000f ) ) {

			//	set (moveDirection) = vector from (current position) to (destination)
			var moveDirection = rayCastDestination.point - transform.position;

			//	normalize (moveDirection)
			moveDirection = moveDirection.normalized;

			//	addforce in (moveDirection)
			rigidbody.AddForce ( moveDirection * speed);
		}
	}
}

//Update:
//If player clicks...
//	Raycast from mouse cursor.
//	remember RaycastHit impact point as (destination)
//	set (moveDirection) = vector from (current position) to (destination)
//	normalize (moveDirection)
//	addforce in (moveDirection)