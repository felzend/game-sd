﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleachers : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.AddComponent<BoxCollider>();

        this.GetComponent<Rigidbody>().mass = 500;
        this.GetComponent<Rigidbody>().isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}