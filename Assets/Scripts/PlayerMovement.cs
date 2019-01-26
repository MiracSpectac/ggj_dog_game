using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis("Vertical");
         float moveHorizontal = Input.GetAxis("Horizontal");
 
         Vector3 newPosition = new Vector3(moveVertical, 0.0f, -moveHorizontal);
         transform.LookAt(newPosition + transform.position);
         transform.Translate(newPosition * speed * Time.deltaTime, Space.World);
	}
}
