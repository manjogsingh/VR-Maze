using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public static bool keyState;
    public GameObject keyPoof;
    public GameObject door;
    void Start(){
        keyState=false;
    }
	public void OnKeyClicked()
	{
        Instantiate(keyPoof,transform.position,Quaternion.identity);

        keyState=true;

        door.GetComponent<Door>().Unlock();

        gameObject.GetComponent<AudioSource>().Play();

        gameObject.GetComponent<MeshRenderer>().enabled=false;
        gameObject.GetComponent<Collider>().enabled=false;
    }
}
