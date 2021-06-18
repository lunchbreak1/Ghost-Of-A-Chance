using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

// An actor is any object that has an interaction with any other object
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteResolver))]
[RequireComponent(typeof(AudioSource))]
public abstract class Actor : MonoBehaviour
{
    protected Rigidbody2D body; // This actor's rigidbody
    protected Collider2D collider; // This actor's collider
    protected SpriteResolver resolver; // This actor's sprite resolver
    protected AudioSource audio; // This actor's audio source
    // Start is called before the first frame update
    protected void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        resolver = GetComponent<SpriteResolver>();
        audio = GetComponent<AudioSource>();
    }
}
