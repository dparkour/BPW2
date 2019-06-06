using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt; // The player
    public Vector3 offset = new Vector3(0, 37.2f, -43.3f);


    private void Start()
    {
        transform.position = lookAt.position + offset;
    }

    private void Update()
    {
        transform.position = lookAt.position + offset;
    }
}

