using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float topSpeed = 10f;
    public float move = 0.5f;

    bool facingRight = true;

    void FixedUpdate()
    { 
    

                float move = 0.2f;
            

            GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        
		
	
}
