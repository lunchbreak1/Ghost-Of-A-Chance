using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : Mover
{
    public bool reflectable, reflected;
    public float lifespan;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        MoveRight();
    }

    void Reflect()
    {
        reflected = true;
    }

    void Die()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;

        switch (tag)
        {
            case "Player":
                Die();
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        switch (tag)
        {
            case "Player":
                Die();
                break;
        }
    }


}
