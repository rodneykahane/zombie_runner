using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float playerHealthPoints = 100f;
    [SerializeField] TextMeshProUGUI healthText;

    private void Update()
    {
        DisplayPlayerHealth();
    }

    private void DisplayPlayerHealth()
    {


        healthText.text = playerHealthPoints.ToString();
    }

    public void ReceiveDamage(float damageTaken)
    {
        playerHealthPoints -= damageTaken;
        if(playerHealthPoints <= 0)
        {
            Debug.Log("you dead");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
    
}
