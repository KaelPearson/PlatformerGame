using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void Update() {

        Vector3 playerTransform = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        transform.position = playerTransform;
    }
}
