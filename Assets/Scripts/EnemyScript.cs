using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float distance;
    public SpriteRenderer renderer;
    public float linearSpeed;
    private Rigidbody2D rgb2d;
    private float startPosition;
 
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        startPosition = rgb2d.position.x;
    }
 
    private void FixedUpdate()
    {
        
        if(startPosition + distance == transform.position.x){
            renderer.flipX = true;
        }
        else if(startPosition == transform.position.x){
            renderer.flipX = false;
        }
        rgb2d.MovePosition(new Vector2((Mathf.Sin((2 * Mathf.PI * (Time.time*linearSpeed/distance)) - (Mathf.PI / 2)) * (distance/2) + (distance/2))+startPosition,rgb2d.position.y));
    }
}
