using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintAdd = 3f;
    public float currentSpeed;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {
        //Inputs
        if(Input.GetKey(KeyCode.X))
        {
            currentSpeed = moveSpeed + sprintAdd;
        }
        else
        {
            currentSpeed = moveSpeed;
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){
        //Physics
        rb.MovePosition(rb.position + movement.normalized * currentSpeed * Time.fixedDeltaTime);
    }
}
