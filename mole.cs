using UnityEngine;
using System.Collections;

public class mole : MonoBehaviour {

	public float appearTime;
	public float disappearTime_min, disappearTime_max;
	enum status {isAscending, isDescending, isUp, isDown, isBeaten, isEnd}
	private float downPos;
	private float upPos;

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//switch status

		//if is Ascending or descending, changPos
	}
	
	void Ascend(){
		//TODO:change status to isAscending
	}
	void descend(){
		//TODO:change status to isDescending
	}

	public int beaten(){
		//if can be beaten
		//TODO: change status to isBeaten
		//return 1;

		//else return 0;
		return 0;
	}
}
