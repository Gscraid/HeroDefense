﻿using UnityEngine;
using System.Collections;

public class TowerTrigger : MonoBehaviour {

	public Tower twr;
	public bool lockE;
	public GameObject curTarget;
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Enemy") && !lockE)
		{
			twr.target = other.gameObject.transform;
			curTarget = other.gameObject;
			lockE = true;
		}
	}
	void Update()
	{
		if(!curTarget)
		{
			lockE = false;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Enemy") && other.gameObject == curTarget)
		{
			lockE = false;
		}
	}
	
}
