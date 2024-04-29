using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingrocks : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D boxCollider;
    [SerializeField] float Distance;
    bool isFalling = false;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        boxCollider=GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if(isFalling == false)
        {
          RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, Distance);
            Debug.DrawRay(transform.position, Vector2.down*Distance, Color.red);
            if(ray.transform != null)
            {
                if(ray.transform.CompareTag("Player"))
                {
                    rb.gravityScale = 10;
                    isFalling= true;
                }
            }
         }
    }
}
