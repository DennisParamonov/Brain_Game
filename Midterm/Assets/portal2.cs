using UnityEngine;
using System.Collections;

public class portal2 : MonoBehaviour {

	public GameObject portal;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log("hi");
		other.gameObject.transform.position = portal.transform.position;

	}
}
