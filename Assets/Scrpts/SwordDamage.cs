using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        // Debug-draw all contact points and normals
        if(collision.gameObject.tag == "enemy")
            
            Destroy(collision.gameObject);
    }
}
