using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;
    private Playerstats Playerstats;
    public GameObject player;

    void Start()
    {
        Playerstats = FindObjectOfType<Playerstats>();
    }


    void Update()
    {
        var Player = GameObject.FindWithTag("Player");
        var playerPos = Player.transform.position;
        transform.LookAt(playerPos);

        if (Vector3.Distance(transform.position, playerPos) >= MinDist)
        {
            transform.position += transform.forward * (MoveSpeed * Time.deltaTime);


            if (Vector3.Distance(transform.position, playerPos) <= MaxDist)
            {
                // Action not decided yet, therefore enemy only causes 5 hp damage
                Playerstats.playerHealth -= 5;
            }
        }
    }
}