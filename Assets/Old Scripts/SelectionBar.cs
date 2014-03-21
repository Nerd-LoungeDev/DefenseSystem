using UnityEngine;
using System.Collections;

public class SelectionBar : MonoBehaviour {


	GUIContent[] selectionBar;
	int selectionBarSize = 8;
	int iconSize = 80;
	int padding = 5;
	

	void OnGUI(){
		GUI.Box (new Rect (0, 0, iconSize * selectionBarSize + padding * 2, 95),"");
		for (int i = 0; i < selectionBarSize; i++) {
			GUI.Box(new Rect (iconSize * i + padding, 5, iconSize, iconSize),"item"+i);
		}
	}
}
