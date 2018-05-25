using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    //public static Transform[] points;

    //public static WayPoints s_Singleton;

    public bool isBlocked = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sonde"))
        {
            if (!isBlocked)
            {
                other.GetComponent<AI_Script>().DefineNextWayPoint(transform);
            }
        }
    }

    void Start()
    {
      /*  points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }*/
    }

    // Update is called once per frame
    void Update () {
		
	}
}
