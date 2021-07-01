using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int MaxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = MaxHealth;
        animator.SetBool("dead", false);
    }
    // Update is called once per frame
   public void TakeDamge(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    

    void Die()
    {
        animator.SetBool("dead",true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
}
