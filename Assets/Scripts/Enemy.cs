using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Mover, IDamageable
{
    [SerializeField]
    private float attackRechargeTime,
        attackCooldownRemaining;

    bool canAttack;

   public GameObject player;
    public Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > transform.position.x)
        {
            FaceRight();
            projectile.FaceRight();
        }

        if (player.transform.position.x < transform.position.x)
        {
            FaceLeft();
            projectile.FaceLeft();
        }
    }

    void Attack()
    {
        if(canAttack)
        {
            projectile.gameObject.SetActive(true);
        }

        canAttack = false;
        Invoke("Recharge", attackRechargeTime);
    }

    void Recharge()
    {
        canAttack = true;
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}
