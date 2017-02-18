using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Door : MonoBehaviour 
{
    public static bool locked;
    bool open;
    public AudioClip doorOpen;
    public AudioClip doorClosed;
    AudioSource source;
    Animator anim;

    public Text doorMessage;
    void Start()
    {
        locked=true;
        open=false;
        anim=transform.GetComponent<Animator>();
        source=gameObject.GetComponent<AudioSource>();
    }
    void Update() {
        
        if(locked==false)
        {
            open=true;
        }
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
    }

    public void OpenGate()
    {
        if(open==true)
        {
            anim.Play("Open");
            gameObject.GetComponent<BoxCollider>().enabled=false;
            source.clip=doorOpen;
            source.Play();
        }
        else
        {
            doorMessage.text="Can't open without key";
            Invoke("DoorText",2.0f);
            source.clip=doorClosed;
            source.Play();
        }
    }
    void DoorText()
    {
        doorMessage.text="";
    }
}
