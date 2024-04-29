using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectDiamond : MonoBehaviour
{
    int DiamondNum;
    [SerializeField] Text Diamondtxt;
    [SerializeField] AudioSource collect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Diamond")
        {
            collect.Play();
            Destroy(collision.gameObject);
            DiamondNum++;
            Diamondtxt.text = "Diamond : " + DiamondNum; 
        }
       
    }
}
