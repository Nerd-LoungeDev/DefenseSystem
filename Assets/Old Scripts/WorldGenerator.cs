using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour {

	public GameObject Cube;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 32; x++) {
			for (int z = 0; z < 32; z++) {
				Instantiate ( Cube, new Vector3(x,1,z), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
