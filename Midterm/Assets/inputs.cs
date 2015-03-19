using UnityEngine;
using System.Collections;

public class inputs : MonoBehaviour {
	
	public AudioSource mySource;
	public AudioSource squishSounds;
	float delay = .5f;

	public AudioClip[] angry;
	public AudioClip[] sad;
	public AudioClip[] happy;
	public AudioClip[] confused;
	public AudioClip[] insane;
	public AudioClip[] wildcard;
	public AudioClip[] squishy;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.UpArrow)){
			Debug.Log("Happy");
			mySource.clip = happy[Random.Range(0,happy.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Debug.Log("Sad");
			mySource.clip = sad[Random.Range(0,sad.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}

		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Debug.Log("Angry");
			mySource.clip = angry[Random.Range(0,angry.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}

		if(Input.GetKeyDown(KeyCode.DownArrow)){
			Debug.Log("Confused");
			mySource.clip = confused[Random.Range(0,confused.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("Insane");
			mySource.clip = insane[Random.Range(0,insane.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("Wildcard");
			mySource.clip = wildcard[Random.Range(0,wildcard.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
		}
	
	
	}
}
