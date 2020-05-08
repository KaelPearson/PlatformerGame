using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            SceneManager.LoadScene(level);
        }
    }
    public void startGame(string level1){
        SceneManager.LoadScene(level1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
