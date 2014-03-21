using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject playerHead;
	
	float sensitivity = 4;
	float moveSpeed = 5;

	float jumpForce = 1000;
	bool isGrounded = true;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		// Basic walk movement
		if (Input.GetButton ("Forward")) {
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetButton ("Back")) {
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);		
		}
		if (Input.GetButton ("Left")) {
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);		
		}
		if (Input.GetButton ("Right")) {
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);		
		}

		// Basic view movement
		transform.Rotate(Vector3.up, Input.GetAxis ("Mouse X") * sensitivity, Space.World);
		playerHead.transform.Rotate(Vector3.left, Input.GetAxis ("Mouse Y") * sensitivity, Space.Self);
	
		// Basic jump movement
		if (Input.GetButtonDown ("Jump") && isGrounded) {
			rigidbody.AddForce(Vector3.up * jumpForce);
			isGrounded = false;
		}
	}

	void OnCollisionEnter(Collision collision) {

		// check if player is in the air
		if (!isGrounded && rigidbody.velocity.y <= 0)
		isGrounded = true;
	}


}
