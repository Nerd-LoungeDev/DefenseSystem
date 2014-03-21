using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	// Inventory Setup
	int inventorySize = 20;
	Item[] item;
	
	// Use this for initialization
	void Start () {
		item = new Item[inventorySize];
	}

	void OnGUI(){
		if (Input.GetButtonDown ("Inventory")) {
			GUI.Box (new Rect (50, 50, 400, 400), "Inventory");
			for (int i = 0; i < inventorySize; i++) {
				if (item [i] != null) {
					GUI.Box (new Rect (10 * i + 50, 10 * i + 50, 10, 10), item [i].name);
				}
			}
		}
	}


	// Update is called once per frame
	void Update () {

	}
}
