using UnityEngine;
using System.Collections;

public class enumerationss : MonoBehaviour {
	public enum browsers {firefox, chrome, IE};
	public browsers myBrowser = browsers.chrome;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myBrowser = changeBrowser (myBrowser);
	}
	browsers changeBrowser (browsers def) {
		if (def == browsers.chrome || def == browsers.firefox) {
			def = browsers.IE;
			return def;
		} else {
			def = browsers.chrome;
			return def;
		}
	}
}
