using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Speed;
    void Update()
    {
        if(Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0,0,Speed);
        }
        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity += new Vector3(-Speed,0,0);
        }
        if(Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0,0,-Speed);
        }
        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity += new Vector3(Speed,0,0);
        }
    }
}
