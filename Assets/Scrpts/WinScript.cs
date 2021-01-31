using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int winDistance;
    public void Awake()
    {
        Win(false,true,true);
    }
    public void Win(bool showText, bool movementScript, bool playerRotation)
    {
        GameObject.Find("WinText").GetComponent<UnityEngine.UI.Text>().enabled = showText;
        //GetComponentInParent<PlayerMovement>().enabled = movementScript;
        //GetComponentInParent<PlayerRotation>().enabled = playerRotation;
    }
    void Update()
    {
        if(Vector3.Distance(GameObject.Find("Player2").transform.position, transform.position) < winDistance)
        {
            Win(true, false, false);
        }


    }
}
