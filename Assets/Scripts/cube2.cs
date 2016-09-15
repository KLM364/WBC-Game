using UnityEngine;
using System.Collections;

public class cube2 : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		//gameObject.SetActive (false);
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	IEnumerator Example() {

		yield return new WaitForSeconds(2);
		rend.enabled = true;
	}
	// Update is called once per frame
	void Update () {
		//rend.enabled = false;	 
		StartCoroutine (Example());
	}
}
