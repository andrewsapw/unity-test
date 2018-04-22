using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class moveROBOT : MonoBehaviour {

	public Transform end;
	
	Rigidbody2D robot;
	Animator rob_anim;



	// Use this for initialization
	void Start () {
		robot = GetComponent<Rigidbody2D>();
		rob_anim = GetComponent<Animator>();
	}
	
	void Move(float speed){
		robot.velocity = new Vector2(speed, robot.velocity.y);
		rob_anim.SetFloat("Speed", 1);
	}

	void Stop(){
		robot.velocity = Vector2.zero;
		rob_anim.SetFloat("Speed", 0);
	}
	// Update is called once per frame
	void Update () {
		print(transform.position.x.ToString() + " " + end.position.x.ToString());
		if(transform.position.x > end.position.x){
			Move(-10);
		}
		else{
			Stop();
		}
	}
}
