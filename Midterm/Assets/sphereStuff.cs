using UnityEngine;
using System.Collections;

public class sphereStuff : MonoBehaviour {
	
	Color colorStart;
	Color colorEnd;
	float rate = 1;
	float i = 0;
	float newScale;
	float ratio;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody>().AddForce(Vector3.forward* Random.Range (-1000,-1500));

		ratio = Time.deltaTime;
		InvokeRepeating("ChangeScale",.5f,.5f);

		colorStart = new Color(Random.value, Random.value, Random.value);
		colorEnd = new Color(Random.value, Random.value, Random.value); 

	}

	// Update is called once per frame
	void Update () {



		float newY = Mathf.Lerp(transform.localScale.y,newScale,ratio);
		float newX = Mathf.Lerp(transform.localScale.x,newScale,ratio);
		float newZ = Mathf.Lerp(transform.localScale.z,newScale,ratio);
		transform.localScale = new Vector3(newX,newY,newZ);

		i += Time.deltaTime*rate;
		GetComponent<Renderer>().material.color = Color.Lerp (colorStart, colorEnd, i);

		if(i >= 1) {
			i = 0;
			colorStart = GetComponent<Renderer>().material.color;
			colorEnd = new Color(Random.value, Random.value, Random.value);
		}
	}
	void ChangeScale(){
		newScale = Random.Range(0f,2f);
}
}
