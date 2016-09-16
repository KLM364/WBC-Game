using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {
	
	public void ButtonClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main");
    }
}
