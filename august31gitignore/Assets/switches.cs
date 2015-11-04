using UnityEngine;
using System.Collections;

public class switches : MonoBehaviour {
	int happiness = 0;
	// Use this for initialization
	void Start () {
		Debug.Log (happiness);
	}
	
	// Update is called once per frame
	void Update () {
	switch (happiness) {
		case 0:
			Debug.Log (happiness);
			happiness += 50;
			break;
		case 50:
			Debug.Log (happiness);
			happiness += 50;
			break;
		default:
			Debug.Log ("what?");
			break;
		


		}

	}
}
