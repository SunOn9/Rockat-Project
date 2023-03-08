using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 4f;

    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
        enabled = false;
    }

    public void Update()
    {
        Vector2 dir = Vector2.zero;
 
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    dir.x = 1;
                    animator.SetInteger("Direction", 2);
                }

                else
                {
                    if (Input.GetKey(KeyCode.W))
                    {
                        dir.y = 1;
                        animator.SetInteger("Direction", 1);
                    }
                    else if (Input.GetKey(KeyCode.S))
                    {
                        dir.y = -1;
                        animator.SetInteger("Direction", 0);
                    }
                }
            }

        GetComponent<Rigidbody2D>().velocity = speed * dir;
    }
}
