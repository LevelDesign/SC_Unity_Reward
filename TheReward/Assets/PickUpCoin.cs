using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour {

	void OnCollisionEnter ( )
	{
		GameObject.Destroy ( gameObject ) ;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(Vector3.up * 100 * Time.deltaTime);
	}
}
