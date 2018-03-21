using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochetage : MonoBehaviour {

    public bool CanOpen = false;
    public Transform pivot;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetP = pivot.position;
        transform.RotateAround(targetP, Vector3.forward, 50 * Time.deltaTime);

    }
    public void LockPick()
    {
        CanOpen = true;
        Debug.Log("crochetage en cours");
    }
}
