using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

    public GameObject USB_Icon;
    public GameObject Panel_Story;

    public GameObject ChoixFinalUI;

    public Text Story;
    private string CleTexte;

    public GameObject tutoCrochetage;

    public GameObject pauseUI;

    public GameObject RobotIndication;
    public GameObject Deplacement;
    public GameObject Saccroupir;

    public GameObject BadEnd;
    public GameObject GoodEnd;
    public GameObject sonde;


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
        tutoCrochetage.SetActive(false);
    }

    public void FermerUICrochetage()
    {
    }

    public void ActiverTutoUICrochetage()
    {
        tutoCrochetage.SetActive(true);
    }

    public void FermerTutoUICrochetage()
    {
        tutoCrochetage.SetActive(false);
    }

    public void TutoDeplacementActiver ()
    {
        Deplacement.SetActive(true);
    }

    public void TutoDeplacementDesactiver()
    {
        Deplacement.SetActive(false);
    }

    public void RobotIndicationActiver ()
    {
        RobotIndication.SetActive(true);
    }

    public void RobotIndicationDesactiver()
    {
        RobotIndication.SetActive(false);
    }

    public void SaccroupirActive ()
    {
        Saccroupir.SetActive(true);
    }

    public void SaccroupirDesactive()
    {
        Saccroupir.SetActive(false);
    }

    public void MenuPlayButton()
    {
        SceneManager.LoadScene("Scene_Mikael");
    }
    public void PauseMenuButton()
    {
        SceneManager.LoadScene("Scene_Menu");
    }
    public void MenuQuitButton()
    {
        Application.Quit();
    }

    public void AfficherUIPause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void QuitterPauseUI()
    {
        Game_Manager.s_Singleton.IsPaused = false;
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ChoixFinal()
    {
        ChoixFinalUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Choix1()
    {
        BadEnd.SetActive (true);
        ChoixFinalUI.SetActive(false);
    }

    public void Choix2()
    {
        GoodEnd.SetActive(true);
        sonde.SetActive(false);
        ChoixFinalUI.SetActive(false);

    }
 
}
