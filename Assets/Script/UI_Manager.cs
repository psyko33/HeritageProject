using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

    public GameObject USB_Icon;
    public GameObject Panel_Story;
   
    public Text Story;
    private string CleTexte;

    public GameObject tutoPressE;

    public GameObject pauseUI;

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
        tutoPressE.SetActive(false);
    }

    public void FermerUICrochetage()
    {
    }

    public void ActiverTutoUICrochetage()
    {
        tutoPressE.SetActive(true);
    }
    public void FermerTutoUICrochetage()
    {
        tutoPressE.SetActive(false);
    }

    public void MenuPlayButton()
    {
        SceneManager.LoadScene("Scene_Kevin");
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

   public void RepartirMenu()
    {
        SceneManager.LoadScene("Scene_Menu");

    }
}
