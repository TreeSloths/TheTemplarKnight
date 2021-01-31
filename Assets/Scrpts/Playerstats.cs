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
        //deathPanel.SetActive(false);
        Death(false, true, true);

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
            Death(true, false, false);
            Debug.Log("Player is dead");
            Time.timeScale.Equals(0);
        }
    }

    public void Death(bool showText, bool movementScript, bool playerRotation)
    {
        GameObject.Find("DeathText").GetComponent<Text>().enabled = showText;
        GetComponentInParent<PlayerMovement>().enabled = movementScript;
        GetComponentInParent<PlayerRotation>().enabled = playerRotation;

    }
    
}