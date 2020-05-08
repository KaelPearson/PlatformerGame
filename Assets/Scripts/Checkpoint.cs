using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform spawnAt;
	public Sprite inactiveSprite;
	public Sprite activeSprite;
    public SpriteRenderer renderer;
	bool active = false;

    public static Checkpoint activeCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player" && !active) {

            // Set this checkpoint as active
            active = true;
            renderer.sprite = activeSprite;

            // Set the player's checkpoint
            PlayerHealth pHealth = col.gameObject.GetComponent<PlayerHealth>();
            pHealth.spawnPosition = spawnAt.position;

            if(activeCheckpoint != null) {
                // Deactivate the last checkpoint
                activeCheckpoint.active = false;
                activeCheckpoint.renderer.sprite = inactiveSprite;
            }
            // Change the active checkpoint variable
            activeCheckpoint = this;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
