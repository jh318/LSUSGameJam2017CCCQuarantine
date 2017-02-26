using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1CatchScript : MonoBehaviour {

	private bool hasBarricade = false;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Cat")
        {
            Debug.Log("Caught The Cat");
			GameManager.instance.UpdateP1Score ();
			GameManager.instance.catCount--;
            c.gameObject.SetActive(false);
			//Destroy (c.gameObject);
        }
		if (c.gameObject.tag == "Barricade" && hasBarricade == false) 
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
