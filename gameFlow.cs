using UnityEngine;
using System.Collections;

public class gameFlow : MonoBehaviour {

	public int level;
	private int this_score;
	public int[] score_threshold = {200, 500, 1000,1600, 2400,3400,4500,5700};
	public float[] level_time = {30,30,40,40,50,60,60,60};
	private float timer;



	// Use this for initialization
	void Start () {
		//load level,		//use PlayerPrefs
		//load this_score,
		//set mole: set disappear and appear time, set pitch 
		//set timer = level time
	}
	
	// Update is called once per frame
	void Update () {
		//demonstrate pitches of this stage

		//while loop: 
		//end condition: times up(time <= 0) 
		//time -= delta time
		//pitch track and tell which mole is beaten
		//if beaten return 1 and plus score, else return 0

		//call endup function
	
	}

	void end(){
		//send score
		//if success level ++
		//if score > threshold, load success or faild
	}

	void OnGUI(){
		//show score
		//show time
		//exit button is already in the other script
	}
}
