using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Trigger_Crochetage : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI_Manager.s_Singleton.ActiverTutoUICrochetage();
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI_Manager.s_Singleton.FermerTutoUICrochetage();
        }
    }

}
