﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script is superceded by GameController
 * This script generates pianpang prefabs on the screen
 * 
*
public class PianPangSpawner : MonoBehaviour {


	public GameObject prefabPianPang;
	private Vector3 [] pos = new Vector3[5];

	// Use this for initialization
	void Start () {
		NextRound();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			NextRound ();
		}
	}

	void NextRound(){
		//PinZiGM.ResetGame ();

		for(int i = 0; i < 4; i++){
			pos[i] = new Vector3 (-3 + i * 2, 1, -3);
		}

		for (int i = 0; i < 4; i++) {
			GameObjectUtility.customInstantiate (prefabPianPang, pos [i]);
		}
	}

}
*/