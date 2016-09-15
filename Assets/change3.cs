using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change3 : MonoBehaviour {
	public float WaitS=5.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine(Load());
	
	}
	IEnumerator Load(){
		yield return new WaitForSeconds (WaitS);
		SceneManager.LoadScene("Menu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
