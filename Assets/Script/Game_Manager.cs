using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour {


    private bool JaiCle = false;


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

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ObtenirCle ()
    {
        JaiCle = true;
    }

    public void PlusCle()
    {
        JaiCle = false;
    }

    public bool AiCle ()
    {
        return JaiCle;
    }

}
