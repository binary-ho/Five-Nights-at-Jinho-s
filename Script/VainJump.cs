using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VainJump : MonoBehaviour
{
    public GameObject JumpBody;
    int count;

    void Start()
    {
        //JumpBody.transform.rotation = Quaternion.Euler(RotateBody);
    }
    // Update is called once per frame
    void Update()
    {
        for (; count < 30; count++)
        {
            Vector3 RotateBody = new Vector3(16f, 0, 0);
            JumpBody.transform.Rotate(RotateBody * Time.deltaTime);
        }
    }
}
