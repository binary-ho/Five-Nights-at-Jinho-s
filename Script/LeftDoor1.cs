using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor1 : MonoBehaviour
{
    public Transform LeftDoorTransform;
    public Transform RightDoorTransform;
    float LeftDoorY2;
    float RightDoorY2;

    void Start()
    {
        Transform LeftDoorTransform = GetComponent<Transform>();
        Transform RightDoorTransform = GetComponent<Transform>();
        LeftDoorY2 = LeftDoorTransform.position.y + 2f;
        RightDoorY2 = RightDoorTransform.position.y + 2f;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LeftDoorOpen()
    {
        for (int i = 1; LeftDoorY2 > LeftDoorTransform.position.y; i++)
        {
            LeftDoorTransform.transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
    public void LeftDoorClose()
    {
        for (int i = 1; 0 < LeftDoorTransform.position.y; i++)
        {
            LeftDoorTransform.transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
