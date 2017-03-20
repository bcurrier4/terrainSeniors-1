using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour {

	RaycastHit hit;
	bool isGrabbed;
	Collider h;

	// Use this for initialization
	void Start () {
		isGrabbed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward * 5f, Color.green, 5f);

		if (Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hit, 5f)) { //creaing a raycast


			if (hit.collider.tag == "barrel") {

				if (Input.GetKeyDown (KeyCode.P) && isGrabbed == false) {
					hit.collider.attachedRigidbody.isKinematic = true;
					hit.collider.attachedRigidbody.transform.SetParent (gameObject.transform);
					isGrabbed = true;
				} else {

					if (Input.GetKeyDown (KeyCode.P) && isGrabbed == true) {
						hit.collider.attachedRigidbody.isKinematic = false;
						hit.collider.attachedRigidbody.transform.SetParent (null);
						isGrabbed = false;
					} 



				}






			}




		}






	}
}
