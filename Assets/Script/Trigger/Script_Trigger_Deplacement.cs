using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Trigger_Deplacement : MonoBehaviour {


    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Youpi");
            UI_Manager.s_Singleton.TutoDeplacementActiver();
           
        }
    }

    public void OnTriggerExit(Collider other)
    {
 
        if (other.gameObject.CompareTag("Player"))
        {
            UI_Manager.s_Singleton.TutoDeplacementDesactiver();
        }
    }
}
