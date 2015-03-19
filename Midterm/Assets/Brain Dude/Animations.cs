using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {
	public GameObject Lhand;
	public GameObject Rhand;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Rhand.GetComponent<Animation>().Play("R Hand Iddle");
		//Lhand.GetComponent<Animation>().Play("L Hand Iddle");
		//Lhand.animation.Play ("L Hand Iddle");
		//Rhand.imation.Play ("R Hand Iddle");


		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Happy");
			GetComponent<Animation> ().Play ("Happy");
		} 
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("Sad");
			GetComponent<Animation> ().Play ("Sad");
		} 
		
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Debug.Log("Angry");
			GetComponent<Animation>().Play("Angry");
		}
		
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			Debug.Log("Confused");
			GetComponent<Animation>().Play("Confused");
		}
		
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("Insane");
			GetComponent<Animation>().Play("Insane");
		}
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("Wildcard");
			GetComponent<Animation>().Play("Wildcard");
		}
		
	}

}
