using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour {

	public GameObject Player;
	public Light light;
	public enum GameState{STARTING,MAINMENU,PLAYING,GAMEOVER}
	Collider c;
	Transform spheretrans;

	public enum Direction{N,S,W,E



	};


	GameState currentState;





	// Use this for initialization
	void Start () {
		currentState = GameState.STARTING;

		spheretrans = GetComponent<Transform> ();


	}
	
	// Update is called once per frame
	void Update () {













	}



	void OnTriggerEnter(Collider other)
	{


	}


	void OnTriggerStay(Collider other)
	{

		t += Time.deltaTime;
		light.intensity = Mathf.Lerp(1f,4f,t);

	}

	float t;
	void OnTriggerExit(Collider other)
	{	
		
		

		//Color.lerp
	}





}


