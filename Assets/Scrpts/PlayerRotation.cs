using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public float speed;
    

    void Update()
    {
        GetComponent<Transform>().Rotate(new Vector3(0,speed*(-Screen.width/2+Input.mousePosition.x),0));
        
        
    }
}
