using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Trigger_Robot : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI_Manager.s_Singleton.RobotIndicationActiver();
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI_Manager.s_Singleton.RobotIndicationDesactiver();
        }
    }

}
