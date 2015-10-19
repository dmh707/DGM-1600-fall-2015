using UnityEngine;
using System.Collections;

public class ClassDataType : MonoBehaviour {
	//create a class for baddie
	//include a constructor with parameters
	public class baddie {
		public int badhealth;
		public int badstrength;
		public int badammo;

		public baddie (int hp, int st, int am) {
			badhealth = hp;
			badstrength = st;
			badammo = am;
		}
	}
	

	//create a class for hero
	//include a constructor without parameters
	public class hero {
		public int goodhealth;
		public int goodstrength;
		public int goodammo;

		public hero () {
			goodhealth = 10;
			goodstrength = 100;
			goodammo = 1000;
		}
	}



	// Use this for initialization
	void Start () {

		//create an array for baddies with 3 spots
		baddie [] baddies = [3];

		//create a for loop that creates 3 baddies of different difficulties
		for (int i= 0; i<baddies.Length; i++) {
			baddies[i] = new baddie (i*10, i*20, i*10);
		}


		//create a new hero and then other heros that immitate the first
		hero groupStat = new hero();
		hero link = groupStat;
		hero epona = groupStat;
		hero navi = groupStat;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
