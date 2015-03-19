using UnityEngine;
using System.Collections;

public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("Sad");
			GetComponent<Animation> ().Play ("L Hand Poke");
		} else {
			GetComponent<Animation>().Play("L Hand Iddle");
		}
	}
}
