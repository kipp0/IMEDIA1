using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Animator a;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;
    int isAttacking = 0;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.y = Input.GetAxisRaw("Vertical");
        // isAttacking = Input.GetMouseButtonDown(0);
        a.SetFloat("Horizontal",movement.x);
        a.SetFloat("Vertical",movement.y);
        a.SetFloat("Speed",movement.sqrMagnitude);

        // if (Input.GetMouseButtonDown(0))
        // {
        //     Attack();
        // }
        if (Input.GetKeyDown(KeyCode.LeftControl) && a.GetInteger("isAttacking") != 1)
        {
            a.SetInteger("isAttacking", 1);
            Attack();
        } else {

            a.SetInteger("isAttacking", 0);
        }
        
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    void Attack() {
        Debug.Log("Attacked");
    }
}
