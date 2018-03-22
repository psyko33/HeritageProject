using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochetage : MonoBehaviour {

    public bool CanOpen = false;
 
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void LockPick()
    {
        CanOpen = true;
        Debug.Log("crochetage en cours");
    }
}
