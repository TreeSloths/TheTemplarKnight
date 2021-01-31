using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkingSpeed;

    private void Start()
    {
        walkingSpeed = 0.05f;
    }

    private bool IsPlaying(string name)
    {
        var animationController = gameObject.transform.Find("arthur_01").GetComponent<Animator>();


        foreach (var clipInfo in animationController.GetCurrentAnimatorClipInfo(0))
        {
            Debug.Log(clipInfo.clip.ToString());
            if (clipInfo.clip.ToString() == name)
            {
                return true;
            }
        }

        return false;
    }

    void Update()
    {
        var animationController = gameObject.transform.Find("arthur_01").GetComponent<Animator>();
        //IsClipPlaying();
        //Debug.Log(IsClipPlaying("arthur_idle_01 (UnityEngine.AnimationClip)"));
        if (Input.GetKey("w") && !IsPlaying("arthur_walking_01 (UnityEngine.AnimationClip)") &&
            !IsPlaying("arthur_attack_01 (UnityEngine.AnimationClip)"))
        {
            animationController.Play("arthur_walk_01");
            gameObject.transform.position -= transform.forward * walkingSpeed;
            Debug.Log("hello");
        }

        if (Input.GetMouseButtonDown(0) && !IsPlaying("arthur_attack_01 (UnityEngine.AnimationClip)"))
        {
            animationController.Play("arthur_attack_01");
        }
    }
}