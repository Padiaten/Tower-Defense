﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour {
	private Enemy target;
	// Use this for initialization
	void Start () {
		
	}
	
	//Makes the tower aim at specific target
	void Update () {
		target = transform.GetComponentInChildren<Tower>().Enem2;
		if(target != null){
			Vector3 diff = target.transform.position - transform.position;
			diff.Normalize();

			float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(0f, 0f, (rot_z - 90)); 

		}

	}
}
