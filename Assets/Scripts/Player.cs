using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class controls the playable character Bruno
public class Player : Mover
{
    public KeyCode leftKey, rightKey, upKey, downKey, phaseKey; // The different keys the player can press to control Bruno

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
}
