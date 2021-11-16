using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    
    public AudioClip FootstepClip;
    public AudioSource Source;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)||
        Input.GetKey(KeyCode.S)||
        Input.GetKey(KeyCode.A)||
        Input.GetKey(KeyCode.D))
        {
            if(!Source.isPlaying)
            {
                Source.PlayOneShot(FootstepClip, 0.5f);
            }
        }
    }
}
