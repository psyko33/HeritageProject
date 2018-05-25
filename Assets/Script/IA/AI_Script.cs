using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Script : MonoBehaviour {

    public GameObject tutoRobot;
    //public float speed = 10f;

    // private Transform target;
    //private int wavePointIndex = 0;

    public Transform nextWayPoint;
    public float SondeSpeed;
   

    void Start()
    {
        //target = WayPoints.s_Singleton.points[0];
    }

    void Update()
    {
        //DeplacementAITest();
        DeplacementIA();

    }

    void OnTriggerEnter(Collider other)
    {

        if (Game_Manager.s_Singleton.AiCle() && other.gameObject.tag == "Player")
        {
            tutoRobot.SetActive(true);
        } 
      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e") && Game_Manager.s_Singleton.AiCle())
        {
            
            UI_Manager.s_Singleton.MasquerUsbIcon();
            Game_Manager.s_Singleton.PlusCle();
            tutoRobot.SetActive(false);

        }
    }

    public void OnTriggerExit(Collider other)
    {
        tutoRobot.SetActive(false);
    }

    /* void DeplacementAITest ()
     {
         Vector3 dir = target.position - transform.position;
         transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

         if (Vector3.Distance(transform.position, target.position) <= 0.4f)
         {
            // GetNextWaypoint();
         }
     }

     void GetNextWaypoint()
     {
         if (wavePointIndex >= WayPoints.points.Length - 1)
         {
             speed = 0f;            
             return;
         }
         wavePointIndex++;
         target = WayPoints.s_Singleton.points[wavePointIndex];
     }*/

    public void DeplacementIA ()
    {
        if (transform.position != nextWayPoint.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextWayPoint.position, SondeSpeed * Time.deltaTime);
        }
    }

    public void DefineNextWayPoint (Transform actualWayPoint)
    {
        nextWayPoint = Waypoint_Manager.s_Singleton.GetNextWayPoint(actualWayPoint);
    }

    public void DefineNextWayPointFromStop()
    {
        nextWayPoint = Waypoint_Manager.s_Singleton.GetNextWayPoint(nextWayPoint);
    }

}
