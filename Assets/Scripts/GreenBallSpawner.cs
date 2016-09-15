using UnityEngine;
using System.Collections;

public class GreenBallSpawner : MonoBehaviour {

	public GameObject ballhazard;
	public Vector3 ballspawnValues;
	void Start () {
		StartCoroutine(GBSpawner());
	}

	IEnumerator GBSpawner()
	{
		while (true)
		{
			Vector3 spawnPosition = new Vector3(Random.Range(-ballspawnValues.x, ballspawnValues.x), ballspawnValues.y, ballspawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(ballhazard, spawnPosition, spawnRotation);

		
		}

	}
	

}
