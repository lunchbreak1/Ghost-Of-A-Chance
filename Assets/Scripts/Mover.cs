using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A Mover is any object that can move
public abstract class Mover : Actor
{
    [SerializeField]
    protected float horizontalSpeed, verticalSpeed;

    [SerializeField]
    protected Facing facing;

    // Face the object left

    public void FaceLeft()
    {
        facing = Facing.Left;
    }

    // Face the object right
    public void FaceRight()
    {
        facing = Facing.Right;
    }

    // Move the object
    protected void Move(Vector2 vector)
    {
        vector = new Vector2(vector.x * horizontalSpeed, 
                             vector.y * verticalSpeed);

        transform.Translate(vector * Time.deltaTime);
    }

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

    // Move the object left and face left
    protected void MoveAndFaceLeft()
    {
        MoveLeft();
        FaceLeft();
    }

    // Move the object right and face right
    protected void MoveAndFaceRight()
    {
        MoveRight();
        FaceRight();
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
