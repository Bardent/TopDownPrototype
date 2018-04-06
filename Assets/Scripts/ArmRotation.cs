using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour {

	public int rotOffset = 90;
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		difference.Normalize(); //Makes vectors add up to one

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotOffset);

	}
}
