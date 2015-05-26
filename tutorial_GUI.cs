using UnityEngine;
using System.Collections;

public class tutorial_GUI : MonoBehaviour {

	public GUIStyle style;
	public Texture2D button ;
	private float width;
	private float height;
	private float pos_x;
	private float pos_y;

	// Use this for initialization
	void Start () {
		width = button.width/10;
		height = button.height/10;
		pos_x = Screen.width / 2 - width / 2;
		pos_y = Screen.height / 2 - height / 2;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		
				if (GUI.Button (new Rect (pos_x, pos_y, width, height), button, style)) {
						Application.LoadLevel ("main");
				}
		}
}
