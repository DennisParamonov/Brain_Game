using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class textChange : MonoBehaviour {

	public GameObject canvas;
	public Text words;
	string[] crazy = new string[]{
		"don't turn around","do you hear that?","run","burn it","kill them all"
	};
	
	void Start () {
		words.text = crazy[Random.Range(0, crazy.Length)];
		transform.SetParent(canvas.transform,false);
		words.fontSize = Random.Range (20,40);
	}
	
 	void Update (){
		//Destroy (gameObject, Random.Range(3.0f,6.0f));
		GetComponent<Rigidbody>().AddForce(Vector3.left* Random.Range (-50,50));
		 
	}
}
