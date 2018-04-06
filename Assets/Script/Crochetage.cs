using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochetage : MonoBehaviour
{

    public bool CanOpen = false;
    private bool triggerOn = false;

    private float speed = 2;

    private float time;
    public float timeReset;

    private Vector2 direction;

    // Use this for initialization
    void Start()
    {
        direction = Vector2.up;
        time = timeReset;

    }

    // Update is called once per frame
    void Update()
    {
        Deplacements();
        GetInput();
        Timer();
        

    }

    public void LockPick()
    {
        if (triggerOn == true)
        {
            CanOpen = true;
            Debug.Log("done");
            triggerOn = false;
        }
    }

    void Deplacements()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            direction += Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            direction += Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction += Vector2.down;
        }
    }

    public void OnTriggerEnter2D( Collider2D other)
    {
        triggerOn = true;
        Debug.Log("crochetage en cours");
        LockPick();
    }

    void Timer()
    {
        time -= Time.deltaTime;
        if (time <= 0 && triggerOn == false)
        {
            ActiverCrochetage.s_Singleton.ExitLockPick();
        }

    }
}