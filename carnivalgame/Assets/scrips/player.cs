using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float speed;
    //public GameObject ball;
    public GameObject[] targets;
    private Rigidbody rb;
    private Rigidbody projectile;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
       // projectile = ball.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
           rb.velocity = (transform.right *-speed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = (transform.right *speed);
        }

        for (int i = 0; i < targets.Length; i++)
        {
            //so long as the enemy is not past the rightmost position on the board (3), move them by 0.2 per frame
            if (targets[i].transform.position.x < 29)
            {
                targets[i].transform.position += new Vector3(.2f, 0, 0);
            }
            else
            {
                targets[i].transform.position = new Vector3(0, targets[i].transform.position.y, targets[i].transform.position.z);
            }
        }




            //if the player is in the same position as the enemy, reset them and the key

            // float moveHorizontal = Input.GetAxis("Horizontal");

            // Vector3 movement = new Vector3(moveHorizontal, 0, 0);

            // if (Input.GetMouseButtonDown(0))
            //{
            //ball.transform.position = transform.position + Camera.main.transform.forward * 2;
            //  projectile.velocity = Camera.main.transform.forward * 40; 

            //}
        }


}
