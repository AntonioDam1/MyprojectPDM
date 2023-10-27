using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class attackGhost : MonoBehaviour
{
    public Animator ghostAnimator;
    public UnityEvent isAttacking;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ghostAnimator.SetBool("attack", true);
            isAttacking.Invoke();
        }
    }
}
