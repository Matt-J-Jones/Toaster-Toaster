using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public Item Item; //Item to be deactivated
    public Item Item2; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    
    public AudioClip PickupClip;
    public AudioSource Source;
    
    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item.gameObject.SetActive(false); // Deactivate world object
        Item2.gameObject.SetActive(true); // Activate held object
        Source.PlayOneShot(PickupClip, 0.25f);
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
