using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	GameObject g;
	// Use this for initialization
	void Start () {
		Invoke ("sapwn1", 3.0f);
	}
	void spawn1(){
		Instantiate(g);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
