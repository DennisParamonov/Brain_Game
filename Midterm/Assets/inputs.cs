using UnityEngine;
using System.Collections;

public class inputs : MonoBehaviour {

	enum guyState{
		angry = 6, 
		sad = 1, 
		happy = 2, 
		confused = 3, 
		insane = 4,
		wildcard = 5,
		idle = 0,
	};

	guyState currentState;

	public AudioSource mySource;
	public AudioSource squishSounds;
	float delay = .5f;

	public GameObject angryFab;
	public GameObject sadFab;
	public GameObject happyFab;
	public GameObject confusedFab;
	public GameObject insaneFab;
	public GameObject wildcardFab;
	
	public AudioClip[] angry;
	public AudioClip[] sad;
	public AudioClip[] happy;
	public AudioClip[] confused;
	public AudioClip[] insane;
	public AudioClip[] wildcard;
	public AudioClip[] squishy;


	void Update()
		{
		getInput();
		determineState();
		}

	void determineState(){

		switch (currentState)
		{
			
		case guyState.angry:

			angryFab.gameObject.SetActive(true);
			//angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);
			
			break;
		case guyState.sad:

			sadFab.gameObject.SetActive(true);
			angryFab.gameObject.SetActive(false);
			//sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);

			break;
		case guyState.happy:

			happyFab.gameObject.SetActive(true);
			angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			//happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);
			
			break;
		case guyState.confused:

			confusedFab.gameObject.SetActive(true);
			angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			//confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);
			
			break;
		case guyState.insane:

			insaneFab.gameObject.SetActive(true);
			angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			//insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);
			
			break;
		case guyState.wildcard:

			wildcardFab.gameObject.SetActive(true);
			angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			//wildcardFab.gameObject.SetActive(false);
			
			break;

		case guyState.idle:
			angryFab.gameObject.SetActive(false);
			sadFab.gameObject.SetActive(false);
			happyFab.gameObject.SetActive(false);
			confusedFab.gameObject.SetActive(false);
			insaneFab.gameObject.SetActive(false);
			wildcardFab.gameObject.SetActive(false);

			break;

		default:
			
			break;
			
		}

	}

	void getInput() {
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			mySource.clip = angry[Random.Range(0,angry.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.angry;
		}

		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			currentState = guyState.idle;
		}

	
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			mySource.clip = sad[Random.Range(0,sad.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.sad;
		}
		if(Input.GetKeyUp(KeyCode.RightArrow)){
			currentState = guyState.idle;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			mySource.clip = happy[Random.Range(0,happy.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.happy;
		}
		if(Input.GetKeyUp(KeyCode.DownArrow)){
			currentState = guyState.idle;
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			mySource.clip = confused[Random.Range(0,confused.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.confused;
		}
		if(Input.GetKeyUp(KeyCode.UpArrow)){
			currentState = guyState.idle;
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			mySource.clip = insane[Random.Range(0,insane.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.insane;
		}
		if(Input.GetKeyUp(KeyCode.Space)){
			currentState = guyState.idle;
		}
	
		if (Input.GetMouseButtonDown(0)){
				Debug.Log("wildcard");
			mySource.clip = wildcard[Random.Range(0,wildcard.Length)];
			mySource.PlayDelayed (delay);
			squishSounds.clip = squishy[Random.Range(0,squishy.Length)];
			squishSounds.Play ();
			currentState = guyState.wildcard;
			}
		
			if(Input.GetMouseButtonUp(0)){
				currentState = guyState.idle;
			}
	}

}

