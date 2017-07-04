using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmovement : MonoBehaviour {


        public float speed = 150, addForce = 7;
        public KeyCode vlevo = KeyCode.A, vpravo = KeyCode.D, vverh = KeyCode.W, vniz = KeyCode.S;
        private Vector3 direction;
        private float vertical;
        private float horizontal;
        private Rigidbody2D body;
        private float rotationY;
        private bool jump;
    private Animator animator;
        void Start()
        {
        animator = GetComponent<Animator>();
            body = GetComponent<Rigidbody2D>();
         

           
        }

     

     
        void FixedUpdate()
        {
            body.AddForce(direction * body.mass * speed);

        if (Mathf.Abs(body.velocity.x) > speed / 100f)
        {
            body.velocity = new Vector2(0,0);
        }

        if (Mathf.Abs(body.velocity.y) > speed / 100f)
        {
            body.velocity = new Vector2(0,0);
        }

    }



    void Update()
    {
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        lookPos = lookPos - transform.position;
        float ugol = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(ugol, Vector3.forward);

        animator.SetFloat("walke", 1);

        if (Input.GetKey(vverh))  { vertical = 1; }
        else if (Input.GetKey(vniz)) {  vertical = -1;  }
        else { vertical = 0;   }
     
        if (Input.GetKey(vlevo)) {  horizontal = -1; }
        else if (Input.GetKey(vpravo)) { horizontal = 1; }
        else {horizontal = 0;  }

        if (horizontal == 0 &&vertical == 0) { animator.SetFloat("walke", 0); }
            direction = new Vector2(horizontal,vertical);
      
       
    }
    }

