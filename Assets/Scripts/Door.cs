using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    bool locked;
    Animator anim;
    void Start()
    {
        locked=true;
        anim=transform.GetComponent<Animator>();
    }
    void Update() {
        
        if(locked==false)
        {
            anim.Play("Open");
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
}
