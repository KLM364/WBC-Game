using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Story : MonoBehaviour {
	public Canvas story;
	public Button skip;

	// Use this for initialization
	void Start () {
		story = story.GetComponent<Canvas> ();
		skip = skip.GetComponent<Button> ();
	    story.enabled = true;
	}

	public void Startlevel()
	{
		Application.LoadLevel (1);
	}

}
