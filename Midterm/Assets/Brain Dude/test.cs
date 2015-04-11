using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)){
			GetComponent<Animation> ().Play ("R Hand Poke");
		} else if (Input.GetKeyDown (KeyCode.Space)){
			GetComponent<Animation> ().Play ("R Hand Poke");
		} else if (Input.GetMouseButtonDown(0)){
			GetComponent<Animation> ().Play ("R Hand Poke");
		} else {
			GetComponent<Animation>().Play("R Hand Iddle");
		}


	}
}
