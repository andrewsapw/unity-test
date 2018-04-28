using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mov : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Debug.Log("Game started");
	}
	
	// Update is called once per frame
	void Update () {
        var speed = 1;
		 Rigidbody2D rb = GetComponent<Rigidbody2D>();
         if (Input.GetKey(KeyCode.A)) //move to left
             rb.transform.Translate(Vector3.left * speed * Time.deltaTime);
         if (Input.GetKey(KeyCode.D)) //move to right
             rb.transform.Translate(Vector3.right * speed * Time.deltaTime);
         if (Input.GetKey(KeyCode.Space)) //jump
             rb.transform.Translate(Vector3.up * 0.2f);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector2.down);
	}
}
