using UnityEngine;
using System.Collections;

public class KittenController : MonoBehaviour {

	public float speed;
	Vector3 directionTime;

	void Start(){
		directionTime = RandomDirectionNumberGenerator() * Time.deltaTime;
	}

	void Update(){
		transform.position += directionTime;
			
	}
		
	Vector3 RandomDirectionNumberGenerator(){
		int x = Random.Range (-1, 2);
		int y = Random.Range(-1,2);
		int z = 0;
		while (x == 0 && y == 0) { // Generate new values if x  and y are 0
			x = Random.Range (-1, 2);
			y = Random.Range(-1,2);
		}
		Vector3 randomDirection = new Vector3((float)x, (float)y, (float)z);
		Debug.Log (randomDirection);
		return randomDirection;
	}
}
