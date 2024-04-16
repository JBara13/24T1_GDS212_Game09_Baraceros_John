using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        //Locking the cursor to the middle of the screen and making it invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //control rotation around x axis
        xRotation -= mouseY;

        //clamp the rotation so we can't over-rotate
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //control rotation around y axis
        yRotation += mouseX;

        //applying both rotations
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
