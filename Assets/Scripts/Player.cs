using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// This class controls the playable character Bruno
public class Player : Mover
{
    [SerializeField]
    [Range(0, 5)]
    private float phaseDuration, // how long Bruno remains phased
        phaseRechargeTime, // how long it takes Bruno's phase ability to recharge
        invincibility; // how long Bruno stays invincible after being hurt

    [SerializeField]
    private bool canPhase, // whether or not Bruno is able to phase
                 phased, // when Bruno is phased, he can pass through solid objects
                 hurt; // if Bruno is hurt, then he can't get hit again for a few seconds

    private SpriteRenderer spriteRenderer;
    private Color solidColor, ghostlyColor;

    // The vector of the player's movement
    private Vector2 movementVector;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        solidColor = spriteRenderer.color;
        ghostlyColor = solidColor;
        ghostlyColor.a *= .5f;
    }
    void Update()
    {
        Move(movementVector);
    }

    private void OnMove(InputValue movementValue) //get the value of the user input
    {
        movementVector = movementValue.Get<Vector2>();

        if(movementVector.x > 0)
        {
            FaceRight();
        }
        else if(movementVector.x < 0)
        {
            FaceLeft();
        }
    }

    // Phase and turn intangible for a brief duration
    void OnPhase()
    {
        if(phased)
        {
            Revert();
            return;
        }
        phased = true;
        gameObject.layer = LayerMask.NameToLayer("Phased");
        spriteRenderer.color = ghostlyColor;
    }

    // Revert back to normal from phase
    void Revert()
    {
        phased = false;
       // remainingCooldown = cooldownLength - remainingGhostly;
       // remainingGhostly = ghostlyLength;
        gameObject.layer = LayerMask.NameToLayer("Player");
        spriteRenderer.color = solidColor;
    }

    // Restore Bruno's ability to phase
    void ReadyPhase()
    {
        Debug.Log("Ready!");
    }

    // End Bruno's period of invincibility
    void EndInvincibility()
    {
        Debug.Log("End Invincibility!");
    }
}
