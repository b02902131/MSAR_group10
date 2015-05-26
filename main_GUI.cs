using UnityEngine;
using System.Collections;

public class main_GUI : MonoBehaviour {


	public GUIStyle style;
	public const int buttom_num = 3;
	public Texture2D[] button ;
	private float[] width = new float[buttom_num];
	private float[] height= new float[buttom_num];
	private float[] pos_x= new float[buttom_num];
	private float[] pos_y= new float[buttom_num];
	private string[] level_name = {"game","tutorial","highScore"};
	// Use this for initialization
	void Start () {
		for (int i = 0; i< buttom_num; i++) {
			width [i] = button [i].width/10;
			height [i] = button [i].height/10;
		}
		pos_x [0] = Screen.width / 2 - width[0] / 2;
		pos_y [0] = Screen.height / 2 - height[0] / 2;
		pos_x [1] = Screen.width / 2 - 1/2 * width[1];
		pos_y [1] = Screen.height / 2 - 3/2 * height[1];
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		//button start
		for (int i = 0; i< buttom_num; i++) {
			if (GUI.Button (new Rect (pos_x [i], pos_y [i], width [i], height [i]), button[i], style)) {
				print ("press!"+i);
				Application.LoadLevel(level_name[i]);
			}
		}
		//button to tutorial
		//button score
		//button setting
	}
}
