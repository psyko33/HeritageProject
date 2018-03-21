using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Script : MonoBehaviour {

    public GameObject tutoRobot;
    public float speed = 10f;

    private Transform target;
    private int wavePointIndex = 0;

    void Start()
    {
        target = WayPoints.points[0];
    }

    void Update()
    {
        DeplacementAI();

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
            tutoRobot.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        tutoRobot.SetActive(false);
    }

    void DeplacementAI ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
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
        target = WayPoints.points[wavePointIndex];
    }
}
