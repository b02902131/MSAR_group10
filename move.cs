﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0, 1, 0) * Time.deltaTime;
	}

	void Ascend(){
		//TODO:change status to isAscending
	}
	void descend(){
		//TODO:change status to isDescending
	}
}
