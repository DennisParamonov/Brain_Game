using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class textChange : MonoBehaviour {

	public GameObject canvas;
	public Text words;
	public GameObject texty;
	public int min, max;

	void Start () {
		transform.SetParent(canvas.transform,false);
		words.fontSize = Random.Range (10,30);
	}
	
 	void Update (){
		//Destroy (gameObject, Random.Range(3.0f,6.0f));
		GetComponent<Rigidbody>().AddForce(Vector3.left* Random.Range (-1000,1000));
		 
	}
}
