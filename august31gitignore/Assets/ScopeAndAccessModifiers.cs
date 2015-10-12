using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int alpha = 5;
	public int alphabeta;
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 29;
		alphabeta = alpha;
		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(alpha, myOtherClass.apples);


	}
	
	
	void Example (int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * alpha;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		if (alphabeta != alpha) {
			Debug.Log ("Alpha is set to: " + alpha);
			alphabeta = alpha;
		}
	}
}