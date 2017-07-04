using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixcam : MonoBehaviour {
    private Transform cam;
	// Use this for initialization
	void Start () {
        cam = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        cam.rotation.z.Equals(0);
	}
}
