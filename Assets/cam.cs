using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

	public BallPrefab ball_prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			BallPrefab ball = Instantiate<BallPrefab>(ball_prefab);
			ball.transform.localPosition = transform.position;
			ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(750,900));
		}
	}
}
