using UnityEngine;
using System.Collections;

public class Playermove : MonoBehaviour {
	Rigidbody2D rb;
	public float jumpForce;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void jump()
	{
		rb.AddForce (new Vector2 (0, jumpForce));
	}
}
