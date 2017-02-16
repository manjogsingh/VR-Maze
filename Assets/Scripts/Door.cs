using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    bool locked;
    bool open;
    public AudioClip doorOpen;
    public AudioClip doorClosed;
    Animator anim;
    void Start()
    {
        locked=true;
        open=false;
        anim=transform.GetComponent<Animator>();
    }
    void Update() {
        
        if(locked==false)
        {
            if(open==true)
            {
                anim.Play("Open");
                gameObject.GetComponent<BoxCollider>().enabled=false;
                gameObject.GetComponent<AudioSource>().clip=doorOpen;
                gameObject.GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            gameObject.GetComponent<AudioSource>().clip=doorClosed;
            gameObject.GetComponent<AudioSource>().Play();
            //cannot open msg
            //also sound
            //audiosource.PlayOneShot(doorClosed);
        }
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
    }

    public void Unlock()
    {
        if(Key.keyState)
        {
            locked=false;
        }
        else
        {
            locked=true;
        }
        // You'll need to set "locked" to false here
    }

    public void OpenGate()
    {
        open=true;
    }
}
