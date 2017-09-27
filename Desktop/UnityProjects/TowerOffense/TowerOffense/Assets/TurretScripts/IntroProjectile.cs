using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroProjectile : Projectile {
	Vector3 direction = Vector3.zero;


	// Update is called once per frame
	void Update () {
		if(direction!=Vector3.zero)
			transform.position += direction * (speed * Time.deltaTime); //The speed * Time.deltaTime makes it frame independent
	}

	public override void Fire(GameObject turret, GameObject target){
		if (turret && target) {
			direction = (target.transform.position - turret.transform.position).normalized;
		}
	}
}
