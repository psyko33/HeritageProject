using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiverCrochetage : MonoBehaviour {

    public Crochetage crochetage;

    public GameObject playerCamera;
    public GameObject cameraSerrure;
    public GameObject player;
    public GameObject UI;


    public static ActiverCrochetage s_Singleton;

    void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }

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
            UI.SetActive(true);
            player.SetActive(false);
            cameraSerrure.SetActive(true);
            UI_Manager.s_Singleton.ActiverUICrochetage();
            crochetage.LockPick();
        } 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        UI_Manager.s_Singleton.ActiverTutoUICrochetage();

    }

    private void OnTriggerExit(Collider other)
    {
        UI_Manager.s_Singleton.FermerTutoUICrochetage();
    }

    public  void ExitLockPick()
    {
        bool CanOpen = crochetage.CanOpen;
 
        if (CanOpen)
        {
            UI.SetActive(true);
            cameraSerrure.SetActive(false);
            player.SetActive(true);
            playerCamera.SetActive(true);
            UI_Manager.s_Singleton.FermerUICrochetage();
            Cursor.visible = false;
            Debug.Log("crochetage fini");
            UI_Manager.s_Singleton.FermerTutoUICrochetage();
            CanOpen = false;
            gameObject.SetActive(false);
        }

            
    }
}
    