using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float playerHealthPoints = 100f;
   

    public void ReceiveDamage(float damageTaken)
    {
        playerHealthPoints -= damageTaken;
        if(playerHealthPoints <= 0)
        {
            Debug.Log("you dead");
            GetComponent<DeathHandler>().handleDeath();
        }
    }
    
}
