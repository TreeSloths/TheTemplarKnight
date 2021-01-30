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
            GetComponent<Rigidbody>().velocity += transform.forward;
        }
        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity -= transform.right;
        }
        if(Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity -= transform.forward;
        }
        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity += transform.right;
        }
    }
}
