using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pausemanager : MonoBehaviour {
	public bool canPause;
	public GameObject PausePanel;


	// Use this for initialization
	void Start () {
		canPause = true;
		PausePanel.SetActive (false);

	}

	public void Pause(){
		if (canPause) {
			Time.timeScale = 0;
			canPause = false;
			PausePanel.SetActive (true);



		} else {
			Time.timeScale = 1;
			canPause = true;;
			PausePanel.SetActive (false);


		}
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
