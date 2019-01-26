using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenDoor : MonoBehaviour {
	bool canOpenDoor = false;
	bool canInteractiveWithDog = false;
	GameObject dog;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.F) ) {
			if ( canOpenDoor ) {
				if ( SceneManager.GetActiveScene().name == "Outside" )
					SceneManager.LoadScene ( sceneName:"Inside" );
				else
					SceneManager.LoadScene ( sceneName:"Outside" );
			}
			if ( canInteractiveWithDog ) {
				dog.GetComponent<Rigidbody>().AddForce(0, 1, 0);
			}
		}
	}

	void OnTriggerEnter(Collider other) {
         if (other.tag == "Door") {
             canOpenDoor = true;
         }
		 else if (other.tag == "Dog") {
			 canInteractiveWithDog = true;
			 dog = other.gameObject;
		 }
     }
     
     void OnTriggerExit(Collider other) {
         if (other.tag == "Door") {
             canOpenDoor = false;
         }
		 else if (other.tag == "Dog") {
			 canInteractiveWithDog = false;
		 }
     }
}
