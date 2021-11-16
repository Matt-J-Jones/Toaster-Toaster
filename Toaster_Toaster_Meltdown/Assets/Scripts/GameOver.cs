using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public AudioClip TadaClip;
    public AudioSource Source;    
    
    // Start is called before the first frame update
    void Start()
    {
       Source.PlayOneShot(TadaClip, 0.05f);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
