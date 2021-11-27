using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public Text winText;

    public int maxHealth = 400;
    public static int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        winText.text = "    ";
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //play hurt animation
        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

        Debug.Log("Enemy died!");
        
        animator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        winText.text = "You Win!";

    }

}
    
