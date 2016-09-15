using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	public void ButtonClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main");
    }
}
