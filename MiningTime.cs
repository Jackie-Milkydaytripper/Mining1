using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningTime : MonoBehaviour {

	bool  printedMessage = false;

	// Use this for initialization
	void Start () {
		print ("Start");
		printedMessage = false;

	}
		
	// Update is called once per frame
	void Update () {

		if (Time.time > 3 && printedMessage == false) {
			print ("It has been three seconds!"); 
			printedMessage = true;

		}

	}
}