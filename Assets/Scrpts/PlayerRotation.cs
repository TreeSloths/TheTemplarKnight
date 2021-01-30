using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public float offset;
    public int speed;
    

    void Update()
    {
        if(Input.mousePosition.x < Screen.width*0.25f)
        {
            GetComponent<Transform>().Rotate(new Vector3(0,-speed,0));
        }
        if(Input.mousePosition.x > Screen.width*0.75f)
        {
            GetComponent<Transform>().Rotate(new Vector3(0,speed,0));
        }
        
    }
}
