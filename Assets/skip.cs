using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void ChangeScene(string scenename)
	{
		SceneManager.LoadScene("Menu");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
