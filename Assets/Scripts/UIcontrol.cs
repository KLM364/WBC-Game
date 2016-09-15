using UnityEngine;
using System.Collections;

public class UIcontrol : MonoBehaviour {

	public void ChangeScene(string scenename)
	{
		Application.LoadLevel (scenename);
	}
	public void LoadScene(string scene)
	{
		Application.LoadLevel (scene);
		Time.timeScale = 1;
	}

}
