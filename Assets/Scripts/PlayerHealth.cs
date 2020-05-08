using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.tag == "BottomOfMap"){
            die();
        }
    }
    void die(){
        transform.position = spawnPosition;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
