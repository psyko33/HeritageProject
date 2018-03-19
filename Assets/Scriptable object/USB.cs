using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class USB : MonoBehaviour {

    public USB_Scriptable USB01;

    public GameObject Scenario; 

    void Start ()
    {
        //Scenario.gameObject = 
        USB01.Print();
	}

   /* void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {

        }
    } */
}
