using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuscript : MonoBehaviour {
	
	public Button playtext;
	public Button quittext;
	// Use this for initialization
	void Start () {
		playtext = playtext.GetComponent<Button> ();
		quittext = quittext.GetComponent<Button> ();

	}
	
	public void Exitpress()
	{

		playtext.enabled = false;
		quittext.enabled = false;
	}
	public void Nopress()
	{

		playtext.enabled = true;
		quittext.enabled = true;
	}
	public void Startlevel()
	{
		Application.LoadLevel (1);
	}
	public void ExitGame()
	{
		Application.Quit ();
	}
}
