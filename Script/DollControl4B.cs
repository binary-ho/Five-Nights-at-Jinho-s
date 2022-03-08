using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollControl4B : MonoBehaviour
{
    public Transform Dolltransform;
    //private bool turn;
    private int i;
    void Start()
    {
        //Transform Dolltransform = GetComponent<Transform>();
        //turn = false;
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 3)
        {

            Dolltransform.Rotate(Vector3.up, 200f);
            i++;
        }
        else if (i >= 3 && i < 6)
        {
            Dolltransform.Rotate(Vector3.up, -200f);
            i++;
        }
        else if (i >= 6)
        {
            i = 1;
        }
    }
}
