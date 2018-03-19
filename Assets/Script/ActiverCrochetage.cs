using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiverCrochetage : MonoBehaviour {

    public Crochetage crochetage;

    public GameObject playerCamera;
    public GameObject player;
    public GameObject cameraSerrure;
    public GameObject serrure;

    private bool IsOpen;

	// Use this for initialization
	void Start ()
    {
        IsOpen = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        ExitLockPick();
	}

    void OnTriggerStay ( Collider other )
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e") && IsOpen == false)
        {
            serrure.SetActive(true);
            playerCamera.SetActive(false);
            player.SetActive(false);
            cameraSerrure.SetActive(true);
            crochetage.Spam();
            
        } 
    }

    void ExitLockPick()
    {
        bool CanOpen = crochetage.CanOpen;

        if (CanOpen == true && Input.GetKeyDown("r"))
        {
            Cursor.visible = false;
            player.SetActive(true);
            playerCamera.SetActive(true);
            cameraSerrure.SetActive(false);
            serrure.SetActive(false);
            CanOpen = false;
            IsOpen = true;
        }
    }
}
