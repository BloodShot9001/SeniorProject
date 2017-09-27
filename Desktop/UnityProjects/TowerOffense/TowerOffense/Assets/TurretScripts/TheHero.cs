using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHero : Minion {
	
	// Update is called once per frame
	void Update () {
		if (this.health <= 0)
			Destroy (this.gameObject);
	}

	void OnCollisionEnter(Collision bullet)
	{
		Debug.Log ("Collision just happened");
		if (bullet.gameObject.tag == "Projectile") {
			Debug.Log ("Collision was with a Projectile");
			this.health = this.health - bullet.gameObject.GetComponent<Projectile> ().damage;
			Destroy (bullet.gameObject);
		}
	}

	public override void Move()
	{

	}
}
