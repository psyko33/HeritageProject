using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public GameObject USBKey;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InteractObjectUSB()
    {
        if (Input.GetKeyDown("e"))
        {
            Destroy(gameObject);
        }
        
    }
}

