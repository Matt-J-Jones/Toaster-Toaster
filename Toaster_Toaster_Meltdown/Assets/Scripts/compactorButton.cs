using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compactorButton : MonoBehaviour
{
    public Item Item_Dea; //Item to be deactivated
    public Item Item_Act; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider
    public bool CompSwitch = false;
    public GameObject Door;
    public Receiver Receiver;
    public AudioClip CompClip;
    public AudioSource Source;
  
    void Update()
    {
      
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Item_Dea.gameObject.SetActive(false); // Deactivate world object
        Item_Act.gameObject.SetActive(true); // Activate held object 
      }
      if(!Source.isPlaying && Input.GetKey(KeyCode.E) && PlayerInTrigger) //Play compactor sounds
      {
          Source.PlayOneShot(CompClip, 0.1f);
      }
      
      if (Input.GetKey(KeyCode.E) && PlayerInTrigger)
      {
        Receiver.Power(0.001f);
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
