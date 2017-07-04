using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixcam : MonoBehaviour {
    private Transform ggerpos;
    private GameObject gger;
    private Vector3 ggerpossss;
	// Use this for initialization
	void Start () {
        gger =  GameObject.Find("glavgeroy");
        
        ggerpos = gger.GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
        ggerpossss = new Vector3(ggerpos.position.x, ggerpos.position.y, Camera.main.transform.position.z) ;

        Debug.Log(ggerpossss.x);
        transform.position = ggerpossss;
    }
    void FixedUpdate()
    {
       

    }
    }
