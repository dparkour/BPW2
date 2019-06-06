using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTargetBehaviour : MonoBehaviour
{ 
    public Transform lookAt; // The player
    private Vector3 position;

    void Update()
    {
        position = new Vector3(0, 0, lookAt.position.z);

        this.gameObject.transform.position = position;

    }
}
