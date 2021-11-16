using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorButton : MonoBehaviour
{
    public Item Item_Dea; //Item to be deactivated
    public Item Item_Act; //Item to be activated
    public bool PlayerInTrigger = false; // Player is in collider

    public Item Cond_1;
    public Item Cond_2;
    public Item Cond_3;
    public bool Cond_Met = false;
    public GameObject Door;
    public Receiver Receiver;

    public AudioClip ButtonClip;
    public AudioSource Source;
  
    void Update()
    {
      if (Cond_1.isActiveAndEnabled && 
      Cond_2.isActiveAndEnabled && 
      Cond_3.isActiveAndEnabled)
      {
        Cond_Met = true;
      }
      
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E) &&
          Cond_Met)                               // check that player is in range and has pressed 'E' Key
      {
        Item_Dea.gameObject.SetActive(false);     // Deactivate "off" Light
        Item_Act.gameObject.SetActive(true);      // Activate "on" Light
      }
      
      if (Input.GetKey(KeyCode.E) && Cond_Met && PlayerInTrigger)
      {
        Receiver.Power(0.001f);                 //Open door
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
