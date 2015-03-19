using UnityEngine;
using System.Collections;

public class instantiate : MonoBehaviour {

	public GameObject sphere;
	public int numberOfSpheres;
	public int min, max;
	
	void Start () {
		PlaceSpheres();	
	}
	void PlaceSpheres()
	{
		for(int i = 0; i < numberOfSpheres; i++)
		{
			Instantiate(sphere, GeneratedPosition(), Quaternion.identity);
		}
	}
	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = Random.Range(min,max);
		y = Random.Range(min,max);
		z = Random.Range(min,max);
		return new Vector3(x,y,z);
	}

	void Update () {
	}
}
