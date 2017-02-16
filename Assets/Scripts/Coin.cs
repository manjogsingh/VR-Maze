using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Coin : MonoBehaviour 
{
    public GameObject coinPoof;
    public AudioClip coinsound;

    public void OnCoinClicked() {

        gameObject.GetComponent<AudioSource>().Play();

        Instantiate(coinPoof,transform.position,Quaternion.identity);
        
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        gameObject.GetComponent<Collider>().enabled=false;
    }

}
