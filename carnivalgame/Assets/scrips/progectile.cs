using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progectile : MonoBehaviour {
    //GameObject projectile;
    public Renderer rend;
    GameObject prefab;
    public AudioSource shoot;
	// Use this for initialization
	void Start () {
        prefab = Resources.Load("sphere") as GameObject;
        // projectile = Instantiate(prefab) as GameObject;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        { 
           GameObject projectile = Instantiate(prefab) as GameObject;
           projectile.transform.position = transform.position + Camera.main.transform.forward * 2;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;

            shoot.Play();
        }
	}
   // void OnCollisionEnter(Collision colReport)
    //{
        //only do something if the collision report says the object collided with was a...
        //game object with a tag property of "duckling"
      //  if (colReport.gameObject.tag == "villan")
        //{
          //  Destroy(other.gameObject);
        //}
    //}

  void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "villan")
        {
            Destroy(other.gameObject);
        }
    }
}
