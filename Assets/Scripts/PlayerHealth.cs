using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public Vector3 spawnPosition;
    bool death = false;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.tag == "Death"){
            death = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(death == true){
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
            transform.position = spawnPosition;
            if(time > 1){  
                death = false;
                canvasGroup.alpha = 0f;
                canvasGroup.blocksRaycasts = false;
                transform.position = spawnPosition;
                time = 0;
            }
            time += Time.deltaTime;
        }
    }
}
