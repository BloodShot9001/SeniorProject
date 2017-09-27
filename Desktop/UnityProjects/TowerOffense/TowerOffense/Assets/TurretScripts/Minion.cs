using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Minion : MonoBehaviour {

	public float health = 5.0f;
	public float speed = 1.0f;

	public abstract void Move();
}
