using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private D
    private bool IsPlaying(string name)
    {
        var animationController = gameObject.transform.Find("arthur_01").GetComponent<Animator>();
        
        
        foreach(var clipInfo in animationController.GetCurrentAnimatorClipInfo(0))
        {
            Debug.Log(clipInfo.clip.ToString());
            if(clipInfo.clip.ToString() == name)
            {
                return true;
            }
            //Debug.Log(clipInfo.clip.ToString());

        }
        return false;
    }
    void Update()
    {
        var animationController =  gameObject.transform.Find("arthur_01").GetComponent<Animator>();
        //IsClipPlaying();
        //Debug.Log(IsClipPlaying("arthur_idle_01 (UnityEngine.AnimationClip)"));
        if(Input.GetKey("w") && !IsPlaying("arthur_walking_01 (UnityEngine.AnimationClip)") && !IsPlaying("arthur_attack_01 (UnityEngine.AnimationClip)"))
        {
            animationController.Play("arthur_walk_01");
            Debug.Log("hello");
            
        }
        if(Input.GetMouseButtonDown(0) && !IsPlaying("arthur_attack_01 (UnityEngine.AnimationClip)"))
        {
            animationController.Play("arthur_attack_01");
        }
       /* else if()
        {
           animationController.Play("arthur_idle_01"); 
        }*/
        
        /*if(Input.GetKey("a"))
        {
            
        }
        if(Input.GetKey("s"))
        {
            
        }
        if(Input.GetKey("d"))
        {
            
        }*/
    }
}
