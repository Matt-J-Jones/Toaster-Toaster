using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public bool Door_Opened = false;
    public bool Toaster_Destroyed = false;
    public bool Keycard_Deposit = false;
    
    public Item Room1Door;
    public Item Room1Marker;
    public Item Toaster;
    public Item ToasterMarker;
    public Item Keycard;
    public Item KeycardMarker;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Toaster.isActiveAndEnabled)
        {
            Toaster_Destroyed = true;
            ToasterMarker.gameObject.SetActive(true);
        }

        if (Room1Door.isActiveAndEnabled)
        {
            Door_Opened = true;
            Room1Marker.gameObject.SetActive(true);
        }

        if (Keycard.isActiveAndEnabled)
        {
            Keycard_Deposit = true;
            KeycardMarker.gameObject.SetActive(true);
        }
    }
}
