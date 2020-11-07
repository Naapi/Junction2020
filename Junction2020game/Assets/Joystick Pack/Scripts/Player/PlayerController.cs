using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;

    public float rotationSpeed = 1f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * joystick.Horizontal);
    }
}
