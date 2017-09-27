using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour {

	public float speed = 5.0f;
	public float damage = 1.0f;

	public abstract void Fire (GameObject turret, GameObject target);

	//This might also need textures or other things, but there are some things I can just make in the subclasses
	//For instance, a rocket could use 3 GameObjects (the turret, a point in the sky for pathing, and the target to finish the path, to give
	//the illusion of a path from the turret to the target)
}
