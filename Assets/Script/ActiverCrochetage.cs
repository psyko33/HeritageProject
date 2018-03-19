using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiverCrochetage : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject player;
    public GameObject cameraSerrure;

    private bool IsUnlocked;
    private bool CanOpen;

	// Use this for initialization
	void Start ()
    {
        IsUnlocked = false;
        CanOpen = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Unlocked();
        ExitLockPick();
	}

    void OnTriggerStay ( Collider other )
    {
       if (other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            playerCamera.SetActive(false);
            player.SetActive(false);
            cameraSerrure.SetActive(true);
            IsUnlocked = true;
        } 
    }

    void Unlocked()
    {
        if (IsUnlocked == true && Input.GetKeyDown("a"))
            Debug.Log("CHEST OPEN");
            CanOpen = true;
    }

    void ExitLockPick()
    {
        if (CanOpen == true && Input.GetKeyDown("r"))
        {
            player.SetActive(true);
            playerCamera.SetActive(true);
            cameraSerrure.SetActive(false);
            CanOpen = false;
        }
    }
}
