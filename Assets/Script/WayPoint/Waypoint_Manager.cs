using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Manager : MonoBehaviour {


    public static Waypoint_Manager s_Singleton;

    public Transform WayPointParent;

    private int WpIdx = 0;

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

    

    public Transform GetNextWayPoint (Transform currentWayPoint)
    {
        WpIdx = currentWayPoint.GetSiblingIndex() + 1;
        return WayPointParent.GetChild(WpIdx);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
