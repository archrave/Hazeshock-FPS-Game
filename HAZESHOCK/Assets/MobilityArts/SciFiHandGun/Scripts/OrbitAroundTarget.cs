using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAroundTarget : MonoBehaviour {

	public GameObject target;

	float speed = 20.0f;

	void Start () {

	}

	void Update () {
		transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
		transform.LookAt(target.transform.position);
	}
}
