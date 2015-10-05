using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("I can count to twelve with loops!");
		int counter = 0; // remember to use counter++ within every loop



		Debug.Log ("for loop");
		// count 1-3

		for (int i = 0; i < 4; i++) {
			Debug.Log (counter);
			counter++;
		}

		Debug.Log ("while loop");
		// count 4-6

		while (counter <7) {
			Debug.Log (counter);
			counter++;
		}

		Debug.Log ("do-while loop");
		// count 7-9

		do {
			Debug.Log (counter);
			counter++;
		} while (counter<9);


		int [] theBookOfNumbers = new int[3];
		theBookOfNumbers[0]= 10;
		theBookOfNumbers[1]= 11;
		theBookOfNumbers[2]= 12;
		Debug.Log ("foreach loop");
		// count 10-12 from theBookOfNumbers
		foreach (int number in theBookOfNumbers) {
			Debug.Log (number);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
