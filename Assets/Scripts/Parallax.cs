using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float relativeSpeed;
    public Transform objectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = -objectToFollow.position.x * relativeSpeed;

        transform.position = nextPosition;
    }
}
