using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ScrollViewPanning : MonoBehaviour {
	public ScrollRect ScrollRect;

	// Use this for initialization
	void Start () {
		LTDescr test = LeanTween.value (this.gameObject, 1, 0, 25f);
		test.setOnUpdate (this.OnUpdate);
	}
	
	// Update is called once per frame
	private void OnUpdate (float val) {
		ScrollRect.verticalNormalizedPosition = val;
	}
}
