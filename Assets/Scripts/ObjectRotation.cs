using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour {
	void Update () {
		transform.RotateAround(transform.position,new Vector3(0,1.0f,0),5.0f);
	}
}
