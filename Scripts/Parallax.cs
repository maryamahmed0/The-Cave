using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public Transform Player;
    Vector2 StartPos;
    float ZPos;
    Vector2 travel => (Vector2)cam.transform.position-StartPos;
    float ParallaxFactor => Mathf.Abs(DisFromPlayer) / clippingPlane;
    float DisFromPlayer => transform.position.z - Player.position.z;
    float clippingPlane => (cam.transform.position.z + (DisFromPlayer > 0 ? cam.farClipPlane : cam.nearClipPlane));
  
    void Start()
    {
        StartPos = transform.position;
        ZPos = transform.position.z;
    }

    void Update()
    {
        Vector2 newPos = StartPos - travel * ParallaxFactor;
        transform.position=new Vector3(newPos.x, newPos.y, ZPos);

    }
}
