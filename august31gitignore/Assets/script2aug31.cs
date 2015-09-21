using UnityEngine;
using System.Collections;

public class script2aug31 : MonoBehaviour {

	int myInt = 26;

	// Use this for initialization
	void Start () {
		//Debug.Log (MultiplyByTwo (myInt));

		
		int myNumber = 0;

		/*myNumber = myNumber + 20;
		myNumber = myNumber * 5;*/

		Debug.Log (myNumber);
	
	
	}
	int MultiplyByTwo (int number) {
		int ret = number * 2;
		return ret;
	}
	// Update is called once per frame
	void Update () {


	}
}
