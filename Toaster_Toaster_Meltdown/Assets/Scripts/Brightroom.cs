using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brightroom : MonoBehaviour
{
    public Item Item;
    public Item EndText;
    private bool PlayerInTrigger = false;
    public Reactor Reactor;
    public AudioClip TadaClip;
    public AudioSource Source;    

    void Update()
    {
        if (PlayerInTrigger) 
        {
            Item.gameObject.SetActive(true);            //Blocks the door back into the game area
            EndText.gameObject.SetActive(true);         //Loads up endgame text
            Reactor.Explosion = false;                  //Turns off the reactor explosions script
            Source.PlayOneShot(TadaClip, 0.1f);         //Plays triumphant sound

            if(Source.isPlaying)
            {
                SceneManager.LoadScene("GameOver");     //Change to game "End State"
            } 
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerInTrigger = true;                     //Checks to see if player is in trigger
        }
    }
}
