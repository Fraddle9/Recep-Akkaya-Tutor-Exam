using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    float mouseSense;

    [SerializeField] Transform player, playerArms;

    Vector3 cameraOffset;

    float xAxisClamp = 0;
    float verticalAngleLimit;

    private void Start()
    {
        verticalAngleLimit = 90f;

        mouseSense = 2;

        Cursor.lockState = CursorLockMode.Locked;

        cameraOffset = new Vector3(0f, 3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;

        xAxisClamp -= rotateY;
        xAxisClamp = Mathf.Clamp(xAxisClamp, -verticalAngleLimit, verticalAngleLimit);

        transform.localRotation = Quaternion.Euler(xAxisClamp, 0f, 0f);
        player.Rotate(Vector3.up * rotateX);

        transform.position = player.position + cameraOffset;
    }
}
