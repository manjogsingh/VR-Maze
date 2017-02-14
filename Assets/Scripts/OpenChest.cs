using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

	public GameObject Canvas;
	public ParticleSystem part1;
	public ParticleSystem part2;
	public void ChestAnimation()
	{
		transform.GetComponent<Animator>().Play("Open");
		Canvas.GetComponent<Animator>().Play("Canvas");
		part1.Play();
		part2.Play();
	}
}
