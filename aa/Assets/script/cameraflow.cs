﻿using UnityEngine;

public class cameraflow : MonoBehaviour {

    public Transform cube;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = cube.position+offset;
	}
}
