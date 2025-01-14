﻿// Reference https://python.iitter.com/other/315447.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_William : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float angle;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation * Quaternion.Euler(new Vector3(1, 0, 0) * angle);
    }
}