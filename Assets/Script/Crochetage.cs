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
        //Vector3 targetP = pivot.position;
        //transform.RotateAround(targetP, Vector3.forward, 50 * Time.deltaTime);
        //Debug.Log(Input.mousePosition);
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 dir = new Vector2(mousePos.x - GetComponent<RectTransform>().position.x, mousePos.y - GetComponent<RectTransform>().position.y);
        transform.up = dir;
        //Quaternion rotation = Quaternion.LookRotation(relativePos);
        //transform.rotation = Quaternion.Euler(new Vector3(rotation.eulerAngles.x, rotation.eulerAngles.y, rotation.eulerAngles.z));

    }
    public void LockPick()
    {
        CanOpen = true;
        Debug.Log("crochetage en cours");
    }
}
