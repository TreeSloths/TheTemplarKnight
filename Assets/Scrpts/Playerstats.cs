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
    public GameObject deathPanel;

    private void Awake()
    {
        deathPanel.SetActive(false);
        Death(Panel: false, movementScript: true, playerRotation: true);

    }

    private void Start()
    {
        playerHealth = 100;
    }

    private void Update()
    {
        playerHealthText.text = $"HP: {playerHealth}";
        //playerHealthText.color = Color.red;
        //playerHealthText.fontSize = 30;

        if (playerHealth <= 0)
        {
            Death(Panel: true, movementScript: false, playerRotation: false);
            Debug.Log("Player is dead");
        }
    }

    public void Death(bool Panel, bool movementScript, bool playerRotation)
    {
        deathPanel.SetActive(true);
        GetComponentInParent<PlayerMovement>().enabled = movementScript;
        GetComponentInParent<PlayerRotation>().enabled = playerRotation;
    }
}