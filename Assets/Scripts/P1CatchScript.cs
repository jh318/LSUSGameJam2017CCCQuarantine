using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1CatchScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Cat")
        {
            Debug.Log("Caught The Cat");

            GameManager.UpdateP1Score();
            
            c.gameObject.SetActive(false);
        }
    }
}
