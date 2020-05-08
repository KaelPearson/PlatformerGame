using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour
{
    public Text powerUpText;
    float time = 0;
    bool jumpIncrease = false;
    void OnTriggerEnter2D(){
        PlayerStats.MaxJumps = 1;
        jumpIncrease = true;
    }
    void Update(){
        if(jumpIncrease == true){
            if(time > 5){
                PlayerStats.MaxJumps = 0;
                time = 0;
                jumpIncrease = false;
                powerUpText.text = "";
            } else {
                powerUpText.text = "Doublejump time remaining: " + (int)(5 - time);
                time += Time.deltaTime;
            }
        }
    }
}
