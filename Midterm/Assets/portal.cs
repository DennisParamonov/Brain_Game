using UnityEngine;
using System.Collections;

public class portal : MonoBehaviour {

	public Transform frontPortal;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		other.gameObject.transform.position = frontPortal.transform.position + 
			new Vector3 (Random.Range(-15f,15f), Random.Range(-15f,15f), 0);
		}

	}
