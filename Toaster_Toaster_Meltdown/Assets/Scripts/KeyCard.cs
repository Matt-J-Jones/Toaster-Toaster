using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    public Item Locked; //Item to be deactivated
    public Item Unlocked; //Item to be activated

    public Item Keycard;
    public bool Keycard_Pickedup = false;
    public Item Bridge;
    public bool PlayerInTrigger = false; // Player is in collider
    public AudioClip BridgeClip;
    public AudioSource Source;    
    
    void Update()
    {
      if (Keycard.isActiveAndEnabled)
      {
        Keycard_Pickedup = false;
      } 
      else
      {
          Keycard_Pickedup = true;
      }
      
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E) &&
          Keycard_Pickedup) // check that player is in range and has pressed 'E' Key
      {
        Locked.gameObject.SetActive(false); // Deactivate Locked Keypad
        Unlocked.gameObject.SetActive(true); // Activate Unlocked Keypad
        Bridge.gameObject.SetActive(true); //Extend Bridge
        Source.PlayOneShot(BridgeClip, 0.2f);  
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
