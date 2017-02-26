using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	
    public float speed;
    public Transform visibleBody;
    public GameObject Catcher;
    public GameObject Cat;
    public string xAxis = "Horizontal";
    public string yAxis = "Vertical";
    public string catchButton = "Catch";
    public string playerName = "player";
	public Sprite playerNeutral;
	public Sprite playerCatch;

	private SpriteRenderer playerSprite; 
    private Rigidbody2D body;


    private void Start()
    {
		playerSprite = GetComponentInChildren<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }
 
	

    IEnumerator CatcherWait()
    {

        Debug.Log(playerName + "tried to catch something");               
           
            
        Catcher.SetActive(true);
        //if (Catcher.gameObject == Cat)
        //{
        //    Cat.SetActive(false);
        //    Debug.Log("Caught The Cat");
        //}
		playerSprite.sprite = playerNeutral;

        yield return new WaitForSeconds(.1f);
		playerSprite.sprite = playerCatch;         

        Catcher.SetActive(false);

        

    }

	void Update(){
        float moveHorizontal = Input.GetAxis(xAxis);
        float moveVert = Input.GetAxis(yAxis);

        Vector3 heading = new Vector3(moveHorizontal, moveVert, 0).normalized;
        body.velocity = heading * speed;
        if (heading.sqrMagnitude > 0.1f) visibleBody.up = heading;
		
        if (Input.GetButtonDown(catchButton))
        {
            StartCoroutine("CatcherWait");
        }
	}
}
