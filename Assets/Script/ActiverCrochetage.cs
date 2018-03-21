using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiverCrochetage : MonoBehaviour {

    public Crochetage crochetage;

    public GameObject playerCamera;
    public GameObject cameraSerrure;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
  

    }
	
	// Update is called once per frame
	void Update ()
    {
        ExitLockPick();
	}

    void OnTriggerStay ( Collider other )
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            playerCamera.SetActive(false);
            player.SetActive(false);
            cameraSerrure.SetActive(true);
            Cursor.visible = false;
            UI_Manager.s_Singleton.ActiverUICrochetage();
            crochetage.LockPick();

        } 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        UI_Manager.s_Singleton.ActiverTutoUICrochetage();

    }

    void ExitLockPick()
    {
        bool CanOpen = crochetage.CanOpen;
 
        if (CanOpen == true && Input.GetKeyDown("r"))
        {
            cameraSerrure.SetActive(false);
            player.SetActive(true);
            playerCamera.SetActive(true);
            UI_Manager.s_Singleton.FermerUICrochetage();
            Cursor.visible = false;
            Debug.Log("crochetage fini");
        }
        if (CanOpen == true)
            UI_Manager.s_Singleton.FermerTutoUICrochetage();
    }
}
