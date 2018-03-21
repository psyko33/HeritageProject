using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    public GameObject USB_Icon;
    public GameObject Panel_Story;
   
    public Text Story;
    private string CleTexte;

 
    public GameObject tutoPressE;
    public GameObject verrou;
    public GameObject crochet;

    public static UI_Manager s_Singleton;

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
  
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void AfficherUsbIcon (USB_Scriptable currentKey)
    {
        USB_Icon.SetActive(true);
        CleTexte = currentKey.Scenario_Text;
    }

    public void MasquerUsbIcon()
    {
        USB_Icon.SetActive(false);
        Panel_Story.SetActive(true);
        Story.text = CleTexte;
    }

    public void ActiverUICrochetage()
    {
        tutoPressE.SetActive(false);
        verrou.SetActive(true);
        crochet.SetActive(true);
    }

    public void FermerUICrochetage()
    {
        verrou.SetActive(false);
        crochet.SetActive(false);
    }

    public void ActiverTutoUICrochetage()
    {
        tutoPressE.SetActive(true);
    }
    public void FermerTutoUICrochetage()
    {
        tutoPressE.SetActive(false);
    }
}
