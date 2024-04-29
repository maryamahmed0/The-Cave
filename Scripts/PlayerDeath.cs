using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    [SerializeField] AudioSource death;
    void Start()
    {
        animator = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    private void Die()
    {
        death.Play();
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    

    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
