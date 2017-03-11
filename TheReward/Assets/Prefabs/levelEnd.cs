using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnd : MonoBehaviour {

	public string nextLevel = "MainMenu";

	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			Debug.Log("Level End");
			Application.LoadLevel(nextLevel);
		}

	}
}
