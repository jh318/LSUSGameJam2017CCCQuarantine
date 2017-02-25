using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Cat")
        {
            Debug.Log("Caught The Cat");
            
            c.gameObject.SetActive(false);
        }
    }
}
