using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Script : MonoBehaviour {

    public GameObject tutoRobot;
    
    
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        if (Game_Manager.s_Singleton.AiCle() && other.gameObject.tag == "Player")
        {
            tutoRobot.SetActive(true);
        } 
      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e") && Game_Manager.s_Singleton.AiCle())
        {
            
            UI_Manager.s_Singleton.MasquerUsbIcon();
            tutoRobot.SetActive(false);
        }
    }

    public void DeplacementAI ()
    {

    }

}
