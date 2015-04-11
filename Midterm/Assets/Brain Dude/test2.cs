using UnityEngine;
using System.Collections;

public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Animation> ().Play ("L Hand Poke");
		} else if (Input.GetKey (KeyCode.LeftArrow)) {

		} else if (Input.GetKey (KeyCode.DownArrow)) {
		}else {

			GetComponent<Animation>().Play("L Hand Iddle");
		}
	}
}
