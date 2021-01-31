using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFlying : MonoBehaviour
{
    // Start is called before the first frame update
    public int turnInterval;
    public int i;
    public float dragonspeed;
    void Update()
    {
        i++;
        if(i >= turnInterval)
        {
            transform.Rotate(0,90,0);
            i=0;
        }
        transform.position += transform.forward * dragonspeed;
    }
}
