using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Coin : MonoBehaviour 
{
    public GameObject coinPoof;
    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {
        Instantiate(coinPoof,transform.position,Quaternion.identity);
        Destroy(gameObject);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
