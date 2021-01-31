using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Playerstats : MonoBehaviour
{
    public int playerHealth;
    public Text playerHealthText;
    public int currentHealth;

    private void Start()
    {
        playerHealth = 100;
    }

    private void Update()
    {
        playerHealthText.text = $"HP: {playerHealth}";
        playerHealthText.color = Color.red;
        playerHealthText.fontSize = 30;

        if (playerHealth <= 0)
        {
            Debug.Log("Player is dead");
        }

        void Death()
        {
            
        }
    }
}