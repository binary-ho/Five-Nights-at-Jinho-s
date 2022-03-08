using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM1ACrtl : MonoBehaviour
{
    public GameObject CM1A;
    public float speed = 2.0f;
    float turningTime = 3.0f;
    float lastTurnigTime;
    bool goRight;
    int move;
    //int cameraNow;

    void Start()
    {

        lastTurnigTime = turningTime;
        Vector3 CM1AR = new Vector3(0f, speed * Time.deltaTime, 0f);
        Quaternion Bound = CM1A.transform.rotation * Quaternion.Euler(CM1AR);
        goRight = true;
        move = 1;
        //cameraNow = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (move < 270 && goRight)
        {
            CM1A.transform.Rotate(0f, -(speed * Time.deltaTime), 0f);
            move++;
        }
        else if (move == 270 && goRight)
        {
            goRight = false;
        }
        else if (move == 0)
        {
            goRight = true;
        }
        else
        {
            CM1A.transform.Rotate(0f, (speed * Time.deltaTime), 0f);
            move--;
        }

        // Debug.Log(goRight);

        // if (goRight)
        // {

        //     if (CM1A.transform.rotation.y > -35.0f)
        //     {
        //         CM1A.transform.Rotate(0f, -(speed * Time.deltaTime), 0f);
        //     }
        //     else
        //     {
        //         goRight = false;
        //     }
        // }
        // else
        // {
        //     if (CM1A.transform.rotation.y < -20.0f)
        //     {
        //         CM1A.transform.Rotate(0f, (speed * Time.deltaTime), 0f);
        //     }
        //     else
        //     {
        //         goRight = true;
        //     }
        // }
    }

    // void CCTV()
    // {
    //     if (cameraNow == 1)
    //     {
    //         cam1.gameObject.SetActive(false);
    //         cam2.gameObject.SetActive(true);
    //         cameraNow = 2;
    //     }
    //     else if (cameraNow == 2)
    //     {
    //         cam2.gameObject.SetActive(false);
    //         cam1.gameObject.SetActive(true);
    //     }
    // }
}
