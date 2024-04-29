using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField] GameObject PointA;
    [SerializeField] GameObject PointB;
    [SerializeField] float Speed;
    Rigidbody2D rb;
    Transform CurrPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CurrPoint = PointA.transform;
    }
    void Update()
    {
        Vector2 point = CurrPoint.position - transform.position;
        if(CurrPoint == PointB.transform)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-Speed, 0);
        }
        if(Vector2.Distance(transform.position,CurrPoint.position) <0.5f && CurrPoint== PointB.transform)
        {
            flip();
            CurrPoint = PointA.transform;
        }
        else if (Vector2.Distance(transform.position,CurrPoint.position)<0.5f && CurrPoint== PointA.transform)
        {
            flip();
            CurrPoint = PointB.transform;
        }
    }
    void flip ()
    {
        Vector2 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
