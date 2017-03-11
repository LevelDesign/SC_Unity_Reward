using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void StartLevel(string levelName){
		Application.LoadLevel(levelName);
	}
}
