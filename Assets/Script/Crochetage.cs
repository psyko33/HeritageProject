using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochetage : MonoBehaviour {

    public bool CanOpen = false;


    private float speed = 2;

    private Vector2 direction;

    // Use this for initialization
    void Start () {
        direction = Vector2.up;
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Deplacements();
        GetInput();

    }

    public void LockPick()
    {
        CanOpen = true;
        Debug.Log("crochetage en cours");
    }

    void Deplacements()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput ()
    {
        direction = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            direction += Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            direction += Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction += Vector2.down;
        }
    }
}