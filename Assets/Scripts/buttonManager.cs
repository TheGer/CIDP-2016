using UnityEngine;
//1.
using UnityEngine.UI;
using System.Collections;

public class buttonManager : MonoBehaviour {

	string input = "";

	//code which is triggered when the button is pressed
	public void helloButtonPressed()
	{
		//1. read the value in the text box
		//2. create a string to write in the output box
		//3. write/update the string to the output box 

		//1.
		string input = GameObject.Find("InputField").GetComponent<InputField>().text;

		//2.
		input = "Hello, " + input;

		//3.
		GameObject.Find ("OutputText").GetComponent<Text> ().text = input;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
