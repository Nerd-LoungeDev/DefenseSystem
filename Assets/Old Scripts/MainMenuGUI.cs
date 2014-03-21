using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	public int menuWidth = 200;
	public int menuHeight = 300;
	public int buttonWidth = 160;
	public int buttonHeight = 50;
	public int spacing = 10;

	int screenMiddleX = Screen.width/2;
	int screenMiddleY = Screen.height/2;

	void OnGUI(){

		GUI.Box (new Rect (screenMiddleX - menuWidth / 2, screenMiddleY - menuHeight / 2, menuWidth, menuHeight), "");
		GUI.Box (new Rect (screenMiddleX - buttonWidth / 2, screenMiddleY - menuHeight / 2 + 20, buttonWidth, buttonHeight), "System Defense");
		if (GUI.Button (new Rect (screenMiddleX - buttonWidth / 2, screenMiddleY - menuHeight / 2 + 20 + (20 + buttonHeight) * 1, buttonWidth, buttonHeight), "Play")) {
			Application.LoadLevel(1);
		}
		GUI.Button(new Rect (screenMiddleX - buttonWidth / 2, screenMiddleY - menuHeight / 2 + 20 + (20 + buttonHeight) * 2, buttonWidth, buttonHeight),"Settings");
		GUI.Button(new Rect (screenMiddleX - buttonWidth / 2, screenMiddleY - menuHeight / 2 + 20 + (20 + buttonHeight) * 3, buttonWidth, buttonHeight),"Exit");




	}
}
