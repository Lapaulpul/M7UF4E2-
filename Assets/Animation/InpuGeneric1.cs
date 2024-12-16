using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpuGeneric1 : MonoBehaviour
{
    private float range = 2.1f;
    private Vector3 offset = new Vector3(0, 1f, 0);
    private Animator animator;
     

   
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position + offset, -transform.up);
        Debug.DrawLine(transform.position + offset, transform.position + offset - transform.up * range, Color.red);
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.layer == 7)
            {
                Debug.Log("Walkable");
                animator.SetBool("isOnGraund", true);
            }
            else
            {
                animator.SetBool("isOnGraund", false);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRuning", true);
        }
        else
        {
            animator.SetBool("isRuning", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }

    }
}
