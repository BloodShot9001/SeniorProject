using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {
	public float speed = 10.0f;
	public GameObject target = null; //set to public to test how rotation/shooting will work
	private Vector3 aimPos = Vector3.zero;
	private Quaternion rotationAngle;

	/*
	// Use this for initialization
	void Start () {
		
		
	}
	*/

	// Update is called once per frame
	void Update () {
		if (target) {
			if (aimPos != target.transform.position)
				aimPos = target.transform.position;
			rotationAngle = Quaternion.LookRotation (aimPos - transform.position);

			if (transform.rotation != rotationAngle)
				transform.rotation = Quaternion.RotateTowards (transform.rotation, rotationAngle, speed * Time.deltaTime);
		}
	}

	bool setTarget(GameObject newTarget){
		if (newTarget != null) {
			target = newTarget;
			return true;
		}
		return false;
	}
}
