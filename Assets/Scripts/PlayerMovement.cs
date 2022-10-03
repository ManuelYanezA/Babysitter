using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintAdd = 3f;
    private float currentSpeed;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

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

        //feeding values to animator
        if (movement.magnitude > 0.5)
            anim.SetBool("IsMoving", true);
        else
            anim.SetBool("IsMoving", false);

        //changing sprite directions
        if (movement.x<=0)
            transform.localScale = new Vector2(1f, 1f);
        else
            transform.localScale = new Vector2(-1f, 1f);
    }

    void FixedUpdate(){
        //Physics
        rb.MovePosition(rb.position + movement.normalized * currentSpeed * Time.fixedDeltaTime);
    }
}
