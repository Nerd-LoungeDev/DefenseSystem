using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Mouse 0")) {
			Screen.lockCursor = true;
			Time.timeScale = 1;
		}
		if (Input.GetKeyDown ("escape")) {
			Screen.lockCursor = false;
			Time.timeScale = 0;
		}
			
	}
}
