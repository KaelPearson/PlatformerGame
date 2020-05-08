using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class Sign : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false; 
    }
    // Update is called once per frame
    void Update()
    {
    }
}
