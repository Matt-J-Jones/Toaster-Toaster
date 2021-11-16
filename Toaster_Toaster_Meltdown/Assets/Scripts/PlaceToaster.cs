using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceToaster : MonoBehaviour
{
    public Item Toaster; 
    public Item CompactorHitbox; 

    public Item HeldToaster;
    public bool PlayerInTrigger = false; // Player is in collider
    public AudioClip PlaceClip;
    public AudioSource Source;    
    
    void Update()
    {
      if (PlayerInTrigger && HeldToaster.isActiveAndEnabled &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        HeldToaster.gameObject.SetActive(false); // Deactivate Toaster
        Toaster.gameObject.SetActive(true); // Place Toaster
        CompactorHitbox.gameObject.SetActive(true); // Activate button
        Source.PlayOneShot(PlaceClip, 0.2f); 
      }
    }

    void OnTriggerEnter(Collider other) // Player has entered collider
    {
      if(other.CompareTag("Player"))
        {
          PlayerInTrigger = true; //Set variable
        }
    }

    void OnTriggerExit(Collider other) // Player leaves collider
    {
      if(other.CompareTag("Player"))
        {
          PlayerInTrigger = false; //unset variable
        }
    }
}
