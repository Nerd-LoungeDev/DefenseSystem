using UnityEngine;
using System.Collections;

public class PlaceBlock : MonoBehaviour {

	public GameObject ghostBlock;
	public GameObject selectedBlock;
	
	Ray ray; // Placeable distance Ray
	RaycastHit hit; // Holds object that intersected raycast
	float workingDistance = 5; // Distance of raycast for block placement and removal


	void Start(){

	}

	// Update is called once per frame
	void Update () {

		// Show where player is looking
		Debug.DrawRay(transform.position, transform.forward * workingDistance);

		// Test if surface is within range for placement
		ray = new Ray (transform.position, transform.forward * workingDistance);
		if (Physics.Raycast (ray, out hit, workingDistance)) {

			// Calculates new block's position in world
			// Places block on proper side of other block
			Vector3 vector = hit.transform.position;
			if (vector.x - hit.point.x == -.5)
				vector.x ++;
			else if (vector.x - hit.point.x == .5)
				vector.x --;
			if (vector.y - hit.point.y == -.5)
				vector.y ++;
			else if ( vector.y - hit.point.y == .5)
				vector.y --;
			if (vector.z - hit.point.z == -.5)
				vector.z ++;
			else if (vector.z - hit.point.z == .5)
				vector.z --;


			GameObject tempGhostBlock;
			if (vector.x != transform.position.x || vector.y != transform.position.y || vector.z != transform.position.z) {
				tempGhostBlock = (GameObject)Instantiate(ghostBlock, vector, Quaternion.identity);
			}
			transform.position = vector;

			// Place real block
			if (Input.GetButtonDown ("Mouse 1")) {
				tempGhostBlock = selectedBlock;
			}
		}


		

		// Remove a block
		if (Input.GetButton ("Mouse 0")) {;
			ray = new Ray (transform.position, transform.forward * workingDistance);
			if (Physics.Raycast (ray, out hit, workingDistance)) {
				BlockStats stats = hit.collider.GetComponent<BlockStats>();
				stats.currentBlockStrength -= 10;
			}
		}
	}


	void loadGhostBlock(){
		ghostBlock = (GameObject)Resources.Load ("Prefabs/GhostCube");
	}
}
