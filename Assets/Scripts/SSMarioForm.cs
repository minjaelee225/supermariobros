using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSMarioForm : MarioForm {

	public SSMarioForm(PlayerController controller, GameObject myGameObject, MarioForm prevMario) : base(controller, myGameObject, prevMario) 
	{
		this.canDuck = true;
	}

}
