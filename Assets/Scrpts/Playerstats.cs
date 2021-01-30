using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerstats : MonoBehaviour
{
    public int playerHealth;
    public Text playerHealthText;

    private void Start()
    {
        playerHealth = 100;
    }

    private void Update()
    {
        playerHealthText.text = $"HP: {playerHealth}";
    }
}