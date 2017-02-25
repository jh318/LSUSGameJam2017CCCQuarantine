using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	
    public float speed;
	

	void Update(){
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVert = Input.GetAxis("Vertical") * speed;

        moveHorizontal *= Time.deltaTime;
        moveVert *= Time.deltaTime;
        transform.position += new Vector3(moveHorizontal, moveVert, 0);
		
	}
}
