using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    public AudioClip AlarmClip;
    public AudioSource Source;
    
    // Start is called before the first frame update
    void Start()
    {
        Source.PlayOneShot(AlarmClip, 0.05f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
