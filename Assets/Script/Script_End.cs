using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_End : MonoBehaviour {

    public GameObject scenario;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scenario.SetActive(false);
            UI_Manager.s_Singleton.ChoixFinal();
        }

    }
}
