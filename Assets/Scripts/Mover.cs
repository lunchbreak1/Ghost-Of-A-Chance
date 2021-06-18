using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : Actor
{
    [SerializeField]
    protected float horizontalSpeed, verticalSpeed;

    // Move the object left
    protected void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * horizontalSpeed);
    }

    // Move the object right
    protected void MoveRight()
    {
        transform.Translate(Vector2.right * Time.deltaTime * horizontalSpeed);
    }

    // Move the object up
    protected void MoveUp()
    {
        transform.Translate(Vector2.up * Time.deltaTime * verticalSpeed);
    }

    // Move the object down
    protected void MoveDown()
    {
        transform.Translate(Vector2.down * Time.deltaTime * verticalSpeed);
    }
}
