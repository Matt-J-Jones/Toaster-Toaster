using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendrawer : MonoBehaviour
{
    public Item Drawer;
    public bool PlayerInTrigger = false;
    public Transform PositionClose;
    public Transform PositionOpen;
    public float T_Value = 0.5f;
    public bool Activated = false;

    public Item LightOff;
    public Item LightOn;

    public AudioClip DrawerClip;
    public AudioSource Source;

    void Update()
    {
      if (PlayerInTrigger &&
          Input.GetKeyDown(KeyCode.E)) // check that player is in range and has pressed 'E' Key
      {
        Drawer.transform.position = Vector3.Lerp
        (
          PositionOpen.position, 
          PositionClose.position,
          T_Value
        );
        Source.PlayOneShot(DrawerClip);
        LightOff.gameObject.SetActive(false);
        LightOn.gameObject.SetActive(true);
        Activated = true;
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
