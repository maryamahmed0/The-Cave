using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    [SerializeField] GameObject Player;
   [SerializeField] float Speed;
    [SerializeField]  float DistanceBetween;
    float Distance;
    Vector2 OriginPos;
    private void Start()
    {
        OriginPos = transform.position;
    }
    void Update()
    {

        Distance = Vector2.Distance(transform.position, Player.transform.position);

        if (Distance < DistanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, Speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(this.transform.position, OriginPos, Speed * Time.deltaTime);
        }
    }
}
