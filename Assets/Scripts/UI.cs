using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {

	public GameObject canvas;
	public Text key;
	public Text coin;
	void Update()
	{
		canvas.transform.position=Vector3.Lerp(gameObject.transform.position,canvas.transform.position,.5f);
		coin.text="Coin : "+Coin.coinCount+"/22";
		
		if(Key.keyState==true)
			key.text="Key : Found";
		else
			key.text="Key : Not Found";
		
		if(OpenChest.chestState==true)
			canvas.SetActive(false);
		else
			canvas.SetActive(true);
	}
}
