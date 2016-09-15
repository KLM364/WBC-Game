using UnityEngine;
using System.Collections;

public class EXitscript : MonoBehaviour {
	public Canvas quitmenu;

	// Use this for initialization
	void Start () {
		quitmenu = quitmenu.GetComponent<Canvas> ();
		quitmenu.enabled = true;
	
	}
	public void ExitGame()
	{
		Application.Quit ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
