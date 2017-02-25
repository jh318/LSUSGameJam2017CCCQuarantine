﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	
    public float speed;
    public Transform visibleBody;
    public GameObject Catcher;
    public GameObject Cat;
	

    IEnumerator CatcherWait()
    {

        Debug.Log("User tried to catch something");               
           
            
        Catcher.SetActive(true);
        //if (Catcher.gameObject == Cat)
        //{
        //    Cat.SetActive(false);
        //    Debug.Log("Caught The Cat");
        //}
                    
        yield return new WaitForSeconds(.1f);

        Catcher.SetActive(false);

        

    }

	void Update(){
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVert = Input.GetAxis("Vertical") * speed;

        Vector3 heading = new Vector3(moveHorizontal, moveVert, 0);
        transform.position += heading * Time.deltaTime;
        if (heading.sqrMagnitude > 0.1f) visibleBody.up = heading;
		
        if (Input.GetButtonDown("Catch"))
        {
            StartCoroutine("CatcherWait");
        }
	}
}
