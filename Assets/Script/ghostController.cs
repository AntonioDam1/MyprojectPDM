using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ghostController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float speedGhost;

    private bool ghostAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        followingPlayer();
    }

    public void Attack() 
    {
        ghostAttacking = true;
    }

    private void followingPlayer() 
    {
        if (ghostAttacking) 
        {
            rb.velocity = new Vector2((-1f) * speedGhost, 0);
        }
    }
}
