using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float moveSpeed;

    private Rigidbody2D myRigidBody;

    public GameManager theGameManager;

	// Use this for initialization
	void Start () {

        myRigidBody = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
    }

    
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "killbox");
        {
            theGameManager.RestartGame();
        }
    }
   
    
}
