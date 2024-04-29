using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicobj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicobj.Length> 1)
        {
            Destroy(this.gameObject);
        }
        else if(musicobj.Length ==1) 
        {
            DontDestroyOnLoad(this.gameObject);
        }
        
    }
}
