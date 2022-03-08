using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM1Ctrl : MonoBehaviour
{
    [SerializeField]
    float mouseSensitivity;

    [SerializeField]
    public Transform CM1Cube;

    Vector3 mouseRestrictionR;
    Vector3 mouseRestrictionL;

    void Start()
    {
        Transform CM1 = GetComponent<Transform>();
        mouseSensitivity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();

    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float rotationAmountX = mouseX * mouseSensitivity;

        Vector3 rotCM1 = CM1Cube.transform.rotation.eulerAngles;

        rotCM1.x = 0;

        rotCM1.z = 0;

        if (rotCM1.y <= 120f && rotCM1.y >= 60f)
        {
            rotCM1.y += rotationAmountX;
            CM1Cube.rotation = Quaternion.Euler(rotCM1);

        }
        else if (120f < rotCM1.y)
        {
            rotCM1.y = 119.99f;
            CM1Cube.rotation = Quaternion.Euler(rotCM1);
        }
        else if (rotCM1.y < 60f)
        {
            rotCM1.y = 60f;
            CM1Cube.rotation = Quaternion.Euler(rotCM1);
        }

        // mouseRestrictionR = (new Vector3(0f, 30f, 0f));
        // mouseRestrictionL = (new Vector3(0f, -30f, 0f));

        // Quaternion stopPointR = Quaternion.Euler(mouseRestrictionR);
        // Quaternion stopPointL = Quaternion.Euler(mouseRestrictionR);

        // if (CM1Cube.rotation.y >= stopPointR.y)
        // {
        //     CM1Cube.rotation = stopPointR;
        // }
        // else if (CM1Cube.rotation.y <= stopPointL.y)
        // {
        //     CM1Cube.transform.rotation = stopPointL;
        // }

    }
}
