using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int first = 5;
		int second = 6;
		if (first < second && first == 6) {
			Debug.Log ("works");
		} else {
			Debug.Log ("this shouldn't happen");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
