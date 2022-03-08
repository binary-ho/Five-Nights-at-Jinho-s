using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMmCtrl : MonoBehaviour
{
    [SerializeField]
    float mouseSensitivity2;

    [SerializeField]
    public Transform CMM;

    void Start()
    {
        Transform CM1 = GetComponent<Transform>();
        mouseSensitivity2 = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();

    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float rotationAmountX = mouseX * mouseSensitivity2;
        float rotationAmountY = mouseY * mouseSensitivity2;

        Vector3 rotCMM = CMM.transform.rotation.eulerAngles;

        rotCMM.x += -rotationAmountY;

        rotCMM.z = 0;
        rotCMM.y += rotationAmountX;
        CMM.rotation = Quaternion.Euler(rotCMM);


    }
}
