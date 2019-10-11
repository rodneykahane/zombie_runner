using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    PlayerHealth target;
    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

   public void AttackHitEvent()
    {
        
        if (target == null) return;
        Debug.Log("successful enemy attack");
        target.ReceiveDamage(damage);        
        
    }


    //this method isnt really doing anything, just an example to show how broadcastmessage works
    public void OnDamageTaken()
    {
        //received info from broadcastmessage in EnemyHealth.CS
        Debug.Log(name + " I also know that we took damage");
    }

}
