using UnityEngine;
using System.Collections;

public class scriptAug31 : MonoBehaviour {

	int myInt = 26;

	// Use this for initialization
	void Start () {
		Debug.Log (MultiplyByTwo(myInt));
	}
	int MultiplyByTwo(int number) {
		int ret = number * 2;
		return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
