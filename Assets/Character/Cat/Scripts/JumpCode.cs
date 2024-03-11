using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animator jAnimation;
    private float animCooldown = 1.5f;
    private float nextAnimTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        jAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jAnimation != null)
        {
            if(Time.time >= nextAnimTime && Input.GetMouseButtonDown(0))
            {
                jAnimation.SetTrigger("Jump");
                nextAnimTime = Time.time + animCooldown;
            }
        }
    }
}
