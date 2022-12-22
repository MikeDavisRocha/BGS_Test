using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Animate();
    }

    private void Animate()
    {
        animator.SetFloat("MovementX", playerMovement.movementInput.x);
        animator.SetFloat("MovementY", playerMovement.movementInput.y);
        animator.SetFloat("Speed", playerMovement.movementInput.sqrMagnitude * playerMovement.movementSpeed);
        animator.SetBool("isShooting", playerMovement.isShooting);
        if (playerMovement.isDead)
        {
            animator.SetTrigger("isDead");
        }
    }
}
