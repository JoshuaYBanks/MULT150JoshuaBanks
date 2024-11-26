using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
             animator.SetTrigger("rot");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
             animator.SetTrigger("pos");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
             animator.SetTrigger("col");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
             animator.SetTrigger("sca");
        }
    }
}
