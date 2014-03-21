using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	int health = 100;

	void OnGUI(){
		GUI.Box (new Rect (0, 100, 80, 25), "Health: " + health);
	}
}
