using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {

	
    public float speed;
    public Transform visibleBody;
    public GameObject Catcher;
    public GameObject Cat;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
 
	

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
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVert = Input.GetAxis("Vertical2");

        Vector3 heading = new Vector3(moveHorizontal, moveVert, 0).normalized;
        body.velocity = heading * speed;
        if (heading.sqrMagnitude > 0.1f) visibleBody.up = heading;
		
        if (Input.GetButtonDown("Catch2"))
        {
            StartCoroutine("CatcherWait");
        }
	}
}
