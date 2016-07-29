using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		Debug.Log ("MY LOG");
		GUI.skin.label.fontSize = 100;
		Debug.LogErrorFormat ("my format {0}", "info1111");
		GUI.Label (new Rect (10, 10, Screen.width, Screen.height), "my hello world111");
	}
}
