using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public float firingRate; float firingTimer;
	public float range;
	public GameObject target; //most of these are public for testing purposes, but would not actually be in a real game
	public GameObject projectile;
	public GameObject spawn; //the location that the bullets are spawned from, preferably the barrel of a gun

	List<GameObject> projectiles;
	
	// Update is called once per frame
	void Update () {
		if (firingTimer >= firingRate) {
			fireProjectiles ();
			firingTimer = 0.0f;
		} else {
			firingTimer += Time.deltaTime;
		}
	}

	void fireProjectiles()
	{
		if (!projectile)
			return;
		GameObject bullet = Instantiate (projectile, spawn.transform.position, Quaternion.Euler (spawn.transform.forward)) as GameObject;
		bullet.GetComponent<Projectile> ().Fire (spawn, target);


	}
}
