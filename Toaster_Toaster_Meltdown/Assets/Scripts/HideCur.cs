using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCur : MonoBehaviour
{
    
    public bool ShowCursor = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = ShowCursor;
        if (ShowCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
