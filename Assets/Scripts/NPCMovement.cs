using UnityEngine;
using System.Collections;

public class NPCMovement : MonoBehaviour {
	
	public float speed = 0.5f;

	public GameObject player;
	
	// FixedUpdate is called once per physics frame / fixed timestep
	void FixedUpdate () {
		
		// always move forward
		GetComponent<Rigidbody>().AddForce ( transform.forward * speed, ForceMode.VelocityChange );
		
		// generate ray
		Ray ray = new Ray ( transform.position, transform.forward );
		
		// actually shoot raycast
		if ( Physics.Raycast ( ray, 3f ) ) {
			// if the raycast hits something, then rotate
			transform.Rotate ( 0f, 95f, 0f );
		}


	}
}
