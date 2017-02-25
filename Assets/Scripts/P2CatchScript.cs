﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2CatchScript : MonoBehaviour {

	private bool hasBarricade = false;

	private void OnTriggerEnter2D(Collider2D c)
	{
		if(c.gameObject.tag == "Cat")
		{
			Debug.Log("Caught The Cat");

			GameManager.UpdateP1Score();

			c.gameObject.SetActive(false);
		}
		if (c.gameObject.tag == "Barricade") 
		{
			Debug.Log("Picked up barricade");
			hasBarricade = true;
			c.gameObject.SetActive (false);
		}
		if (c.gameObject.tag == "Spawner" && hasBarricade == true) 
		{
			c.gameObject.SetActive (false);
			hasBarricade = false;
			Debug.Log ("Stopped spawner");
		}
	}
}
