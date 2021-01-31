using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyMoveSpeed = 4;
    public int maxDistance = 10;
    public int minimumDistance = 5;
    private Playerstats Playerstats;
    public GameObject Player;


    void Start()
    {
        Playerstats = FindObjectOfType<Playerstats>();
    }


    void Update()
    {
        var playerPos = Player.transform.position;
        transform.LookAt(playerPos);

        if (Vector3.Distance(transform.position, playerPos) >= minimumDistance)
        {
            transform.position += transform.forward * (enemyMoveSpeed * Time.deltaTime);


            if (Vector3.Distance(transform.position, playerPos) <= maxDistance)
            {
                Debug.Log("Player is being hit");
                // Action not decided yet, therefore enemy only causes 5 hp damage
                Playerstats.playerHealth -= 5;
            }
        }
    }
}