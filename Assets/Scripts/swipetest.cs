using UnityEngine;
using System.Collections;

public class swipetest : MonoBehaviour {
	public float maxtime;
	public float minswipedist;
	float startTime,endTime;
	Vector3 startPos;
	Vector3 endPos;
	float swipeDistance;
	float swipeTime;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				startTime = Time.time;
				startPos = touch.position;
			}
			else if (touch.phase == TouchPhase.Ended) {
				endTime = Time.time;
				endPos = touch.position;
				swipeDistance = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;
				if (swipeTime < maxtime && swipeDistance > minswipedist) {
					swipe ();
				}
			}
		
		}
	}
	void swipe(){
		Vector2 distance = endPos - startPos;
		if (Mathf.Abs (distance.x) > Mathf.Abs (distance.y)) {
			Debug.Log ("Horizontal swipe");
			if (distance.x > 0) {
				Debug.Log ("Right swipe");
			} 
			else if (distance.x < 0) {
				Debug.Log ("Left Swipe");
			}
		}
	    else if (Mathf.Abs (distance.x) < Mathf.Abs (distance.y)) {
			Debug.Log ("Vertical swipe");
			if (distance.y > 0) {
				Debug.Log ("Up swipe");
				player.GetComponent<Playermove> ().jump ();
			}
			else if (distance.y < 0) {
				Debug.Log ("Down Swipe");
			}
	   }
	}
}
