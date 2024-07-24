using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 2.0f;
        float stageMax = 4.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < stageMax)
            {
                rb.velocity = new Vector3(moveSpeed, 0, 0);
            }
            animator.SetBool("mode", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -stageMax)
            {
                rb.velocity = new Vector3(-moveSpeed, 0, 0);
            }
            animator.SetBool("mode", true);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
            animator.SetBool("mode", false);
        }

    }
    int bulletTimer = 0;
    void FixedUpdate()
    {
        // ’e”­ŽË
        if (Input.GetKey(KeyCode.Space))
        {
            if(bulletTimer == 0)
            {
                Vector3 position = transform.position;
                position.y += 0.8f;
                position.z += 1.0f;
                bulletTimer = 1;

                Instantiate(bullet, position, Quaternion.identity);
            }
            else
            {
                bulletTimer++;
                if(bulletTimer > 30)
                {
                    bulletTimer = 0;
                }
            }
        }
    }
}
