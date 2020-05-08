using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public int maxJumps = 1;
    int currentJumps = 0;
    public PlayerController pCont;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        
        if(Input.GetButtonDown("Crouch")){
            pCont.Crouch();
        }
        if(Input.GetButtonUp("Crouch")) {
	        pCont.UnCrouch();
        }
        if(!Input.GetButton("Jump")) {
	        pCont.CancelJump();
        }
        if(Input.GetButtonDown("Jump") && currentJumps < maxJumps) {
            pCont.JumpUnconditionally();
            currentJumps++;
        }
        if(pCont.isGrounded){
            currentJumps = 0;
        }
        pCont.Move(Input.GetAxis("Horizontal"));       
    }
}
