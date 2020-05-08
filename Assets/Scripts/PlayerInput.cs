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
        
        if(!Input.GetButton("Jump")) {
	        pCont.CancelJump();
        }
        if(Input.GetButtonDown("Jump") && currentJumps < maxJumps) {
            pCont.JumpUnconditionally();
            currentJumps++;
            animator.SetTrigger("pJump");
        }
        if(pCont.landed) {
            currentJumps = 0;
            animator.SetTrigger("pLand");
            animator.ResetTrigger("pJump");
        } else {
            animator.ResetTrigger("pLand");
        }
        if(xDir == 0) {
            animator.SetBool("pIdle", true);
            animator.SetBool("pRun", false);
        } else {
            animator.SetBool("pRun", true);
            animator.SetBool("pIdle", false);
        }
        
        if(pCont.isGrounded){
            currentJumps = 0;
            animator.ResetTrigger("pJump");
        } else {
            animator.SetTrigger("pJump");
        }
        pCont.Move(Input.GetAxis("Horizontal"));       
    }
}
