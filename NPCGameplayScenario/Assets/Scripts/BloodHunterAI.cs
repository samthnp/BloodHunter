using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BloodHunterAI : MonoBehaviour
{
    private Animator animator;
    
    public bool AffectedByFlashBang = false;
    public bool SeePlayer = false;
    public bool CatchPlayer = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FlashBang"))
        {
            StunState();
            Destroy(other.gameObject);
        }
    }

    public void StunState()
    {
        AffectedByFlashBang = true;

        animator.SetBool("IsStunned", true);
        animator.SetBool("IsIdle",false);
        animator.SetBool("IsWalking",false);
        animator.SetBool("IsRunning",false);
        animator.SetBool("DetectPlayer",false);
        animator.SetBool("IscloseToPlayer",false);
        animator.SetBool("IsAttacking",false);
        
        print("Stunned");
    }

    public void RecoverFromStun()
    {
        AffectedByFlashBang = false;
        animator.SetBool("IsStunned", false);
        animator.SetBool("IsIdle",true);
    }

    public void WaitBeforePatrol()
    {
        animator.SetBool("IsStunned", false);
        animator.SetBool("IsIdle",true);
    }

    public void Patrolling()
    {
        animator.SetBool("IsWalking",true);
        animator.SetBool("IsStunned", false);
    }

    public void DetectingPlayer()
    {
        animator.SetBool("IsIdle",false);
        animator.SetBool("IsWalking",false);
        animator.SetBool("DetectPlayer",true);
    }

    public void ChasingPlayer()
    {
        animator.SetBool("IsStunned", false);
        animator.SetBool("DetectPlayer",false);
        animator.SetBool("IsRunning",true);
    }
}
