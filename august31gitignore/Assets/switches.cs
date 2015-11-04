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
			happiness += 20;
			break;
		case 20:
			Debug.Log (happiness);
			happiness += 20;
			break;
		case 40:
			Debug.Log (happiness);
			happiness += 20;
			break;
		case 60:
			Debug.Log (happiness);
			happiness += 20;
			break;
		case 80:
			Debug.Log (happiness);
			happiness += 20;
			break;
		case 100:
			Debug.Log (happiness);
			happiness += 20;
			break;


		}

	}
}
