using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochetage : MonoBehaviour {

    public bool CanOpen = false;

    private Rigidbody2D myRb;
    public float speed = 10;


    // Use this for initialization
    void Start () {
        myRb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Deplacements();

    }

    public void LockPick()
    {
        CanOpen = true;
        Debug.Log("crochetage en cours");
    }

    void Deplacements()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            myRb.AddForce(transform.right *-speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
      
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
     
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
        
        }
    }
}