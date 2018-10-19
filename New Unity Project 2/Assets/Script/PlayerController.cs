using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
     //Public Variables

    public float speed;
    public float jump;
    public bool grounded;
    public LayerMask whatIsGround;

    //Public Private

    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;
    private float speedmulti = 1.000125f;

    // Use this for initialization
    void Start () {
        //gets component
        //myRigidBody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        speed = speed * speedmulti;
        speed = Mathf.Clamp(speed, 5, 100);

        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jump);
            }
        }
	}
}
