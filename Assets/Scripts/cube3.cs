using UnityEngine;
using System.Collections;

public class cube3 : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	IEnumerator Example() {

		yield return new WaitForSeconds(12);
		rend.enabled = true;
	}
	// Update is called once per frame
	void Update () {
		StartCoroutine (Example());
	}
}
