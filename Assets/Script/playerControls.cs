using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedMove;
    public float jumpingPower;
    public SpriteRenderer sprtRnd;
    public Animator animPlayer;
    public Transform transformPlayer;
    public GameObject arrow;

    private float horizontal;
    private bool isFacingRaight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Llamada interna
        checkMovement();
    }

    //Metodo privado que sirve para hacer una llamada interna
    public void checkMovement()
    {
        if (Mathf.Abs(horizontal) != 0f) 
        {
            animPlayer.SetBool("isRunning", true);
        }
        else
        {
            animPlayer.SetBool("isRunning", false);
        }


        if (checkSuelo.isGrounded)
        {
            rb.velocity = new Vector2(horizontal * speedMove, rb.velocity.y);
            animPlayer.SetBool("isSuelo", true);
        }
        else
        {
            animPlayer.SetBool("isSuelo", false);
        }




        if (!isFacingRaight && horizontal > 0f)
        {
            // Girar a la derecha
            isFacingRaight = true;
            sprtRnd.flipX = false;

        }
        else if (isFacingRaight && horizontal < 0f)
        {
            // Girar a la izquierda
            isFacingRaight = false;
            sprtRnd.flipX = true;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }


    public void Jump()
    {
        if(checkSuelo.isGrounded){
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
    }

    public void Shoot()
    {
        //Debug.Log("Disparo");
        Instantiate(arrow,transformPlayer.position, Quaternion.identity);
    }
}
