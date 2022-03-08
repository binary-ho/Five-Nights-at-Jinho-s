using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPass : MonoBehaviour
{
    public Transform Headtransform;
    //private bool turn;
    private int i;
    void Start()
    {
        //Transform Dolltransform = GetComponent<Transform>();
        //turn = false;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 5)
        {
            Headtransform.transform.position += new Vector3(-1f, 0, 0) * Time.deltaTime * 2;
            //Headtransform.Rotate(Vector3.up, 100f);
            i++;
        }
        // else if (i >= 3 && i < 6)
        // {
        //     Headtransform.transform.position += new Vector3(1f, 0, 0) * Time.deltaTime * 2;
        //     //Headtransform.Rotate(Vector3.up, -100f);
        //     i++;
        // }
        // else if (i >= 6)
        // {
        //     i = 0;
        // }
    }
}
