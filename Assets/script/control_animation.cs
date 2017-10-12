using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_animation : MonoBehaviour {

	Animator ani_this;
	Rigidbody2D rig_this;

	void Start () 
	{


		ani_this = gameObject.GetComponent<Animator> ();
		rig_this = gameObject.GetComponent<Rigidbody2D> (); 

	}
	

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			ani_this.SetBool ("ifJump", true); // "ifJump" is the bool set in "Animator panel -> Parameters -> + -> Bool)"
			rig_this.velocity = new Vector2 (0, 4f);

		}
//
		if (Input.GetKeyUp (KeyCode.W)) 
		{
			ani_this.SetBool ("ifJump", false); // see "https://docs.unity3d.com/ScriptReference/Animator.SetBool.html"
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			ani_this.SetBool ("ifWalk", true);
			rig_this.velocity = new Vector2 (5f, 0);
		}
		if (Input.GetKeyUp (KeyCode.D)) 
		{
			ani_this.SetBool ("ifWalk", false);

		}
	}
}
