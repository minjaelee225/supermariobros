using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatPig : Enemy {

	Vector3 currentSpeed;
	protected Animator anim; 
	float num = 100;

	public override void Start() {
		base.Start();
		anim = GetComponent<Animator>();
		currentSpeed = new Vector3(0, 0);
		rb.velocity = currentSpeed;
		scoreValue = 100;
	}

	// Update is called once per frame
	public override void FixedUpdate () {
		if (dead)
		{
			if (timeToDeath <= 0)
			{
				Destroy(this.gameObject);
			}
			timeToDeath -= Time.deltaTime;
		}
		else
		{
			if (num == 0)
			{
				anim.SetBool ("Jump", true);
				currentSpeed.y = 15;
				rb.velocity = currentSpeed;
				num = 100;
			}
			else
			{
				anim.SetBool ("Jump", false);
				num--;
			}
		}
	}
}
