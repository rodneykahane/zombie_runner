using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    //create a public method which reduces hitpoints by the amount of damage

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");

        hitPoints -= damage;
        if(hitPoints <= 0)
        {
            
            //Destroy(gameObject);
           EnemyDeath();
        }
    }

    private void EnemyDeath()
    {
        if (isDead)
        {
            return;
        }
        
        
        isDead = true;
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("die");
        

        
    }
}
