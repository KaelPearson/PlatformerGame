using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            PlayerStats.Coin += 1;
            Destroy(gameObject);
        }
    }
}
