using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour {


    private bool JaiCle = false;
    public bool IsPaused;
    public bool StopWayPoint;
    public AI_Script Sonde;


    public static Game_Manager s_Singleton;

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
        StopWayPoint = false;
        Time.timeScale = 1;
        IsPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
        ActiverPauseUI();
	}

    public void ObtenirCle ()
    {
        JaiCle = true;
    }

    public void PlusCle()
    {
        JaiCle = false;
        Sonde.DefineNextWayPointFromStop();


    }

    public bool AiCle ()
    {
        return JaiCle;
    }

    void ActiverPauseUI()
    {
        if ( Input.GetKeyDown(KeyCode.P))
        {
            if (!IsPaused)
            {
                UI_Manager.s_Singleton.AfficherUIPause();
                IsPaused = true;
            }

           else if(IsPaused)
            {
                UI_Manager.s_Singleton.QuitterPauseUI();
            }
        }
    }
}
