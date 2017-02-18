using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Coin : MonoBehaviour 
{
    public static int coinCount=0;
    public GameObject coinPoof;
    public void OnCoinClicked() {

        coinCount++;

        gameObject.GetComponent<AudioSource>().Play();

        Instantiate(coinPoof,transform.position,Quaternion.identity);
        
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        gameObject.GetComponent<Collider>().enabled=false;
    }

}
