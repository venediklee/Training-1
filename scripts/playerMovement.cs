using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwforce = 1000f, sideforce=500f;

	// Update is called once per frame
	void FixedUpdate () {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwforce*Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce( sideforce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-1)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }


    }
}
