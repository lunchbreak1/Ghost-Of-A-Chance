using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class controls the playable character Bruno
public class Player : Mover
{
    [SerializeField]
    [Range(0, 20)]
    private float phaseDuration, // how long Bruno remains phased
        phaseRechargeTime, // how long it takes Bruno's phase ability to recharge
        invincibility; // how long Bruno stays invincible after being hurt

    [SerializeField]
    private bool canPhase, // whether or not Bruno is able to phase
                 phased, // when Bruno is phased, he can pass through solid objects
                 hurt; // if Bruno is hurt, then he can't get hit again for a few seconds

    [SerializeField]
    private KeyCode leftKey, rightKey, upKey, downKey, phaseKey; // The different keys the player can press to control Bruno




    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    // Move the player using the input keys
    void PlayerMove()
    {
        if (Input.GetKey(leftKey))
        {
            MoveLeft();
        }
        if (Input.GetKey(rightKey))
        {
            MoveRight();
        }
        if (Input.GetKey(upKey))
        {
            MoveUp();
        }
        if (Input.GetKey(downKey))
        {
            MoveDown();
        }
        if (Input.GetKey(phaseKey))
        {
            Phase();
        }
    }

    // Phase and turn intangible for a brief duration
    void Phase()
    {
        Debug.Log("Phase!");
    }

    // Revert back to normal from phase
    void Revert()
    {
        Debug.Log("Revert!");
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
