using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	private class Item{
	}
	
	private class Inventory{
				
	}

	public GameObject playerHead;
	
	float viewSensitivity = 4;
	float movementSpeed = 5;
	
	float jumpForce = 1000;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Walking & Straffing Movement
		if (Input.GetButton ("Forward")) {
			transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
		}
		if (Input.GetButton ("Back")) {
			transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);		
		}
		if (Input.GetButton ("Left")) {
			transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);		
		}
		if (Input.GetButton ("Right")) {
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);		
		}

		// Camera View Movement
		transform.Rotate(Vector3.up, Input.GetAxis ("Mouse X") * viewSensitivity, Space.World);
		playerHead.transform.Rotate(Vector3.left, Input.GetAxis ("Mouse Y") * viewSensitivity, Space.Self);

		// Jump Movement
		Debug.DrawRay(transform.position,Vector3.down);
		if (Input.GetButtonDown ("Jump")){
			Ray ray = new Ray(transform.position, Vector3.down);
			if(Physics.Raycast(ray,1)){
				rigidbody.AddForce(Vector3.up * jumpForce);
			}
		}
	}
}
