﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // members or variables
    public float moveSpeed = 7.0f;

    public GameObject bulletSpawner;
    public GameObject bullet;

    // methods or functions

	
	// Update is called once per frame
	void Update () {
		// player movement 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.W))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if(Input.GetKey(KeyCode.A))
            transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.S))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if(Input.GetKey(KeyCode.D))
            transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
	}
    void Shoot() {
        Instantiate(bullet.transform, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
    }
}
