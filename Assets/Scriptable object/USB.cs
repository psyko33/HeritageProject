using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class USB : MonoBehaviour {


    public USB_Scriptable USBKey;

    public Text Scenario;
    public GameObject tuto;
    public GameObject afficherIcone;

    void Start ()
    {
        
        afficherIcone.SetActive(false);
        
    }
    
    void OnTriggerStay(Collider other)
    {
        tuto.SetActive(true);

        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e") )
        {
            
            gameObject.SetActive(false);
            Game_Manager.s_Singleton.ObtenirCle();
            UI_Manager.s_Singleton.AfficherUsbIcon(USBKey);
            tuto.SetActive(false);

        }
    } 
}
