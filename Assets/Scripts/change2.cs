using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change2 : MonoBehaviour {

	public float WaitS=5.0f;
	void Start () {


		StartCoroutine(Load());
		//SceneManager.LoadScene("Menu");

	}
	IEnumerator Load(){
		yield return new WaitForSeconds (WaitS);
		SceneManager.LoadScene("Menu");
	}
}
