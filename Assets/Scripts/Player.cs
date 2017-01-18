using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed, move_x, move_y, refireDelay;
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//movement
		move_x = Input.GetAxis ("Horizontal");
		move_y = Input.GetAxis ("Vertical");
		move_x *= Time.deltaTime * 10;
		move_y *= Time.deltaTime * 10;
		transform.Translate (move_x, move_y, 0);
		//shooting
		refireDelay -= Time.deltaTime;
		if (Input.GetButton("Fire1") && refireDelay < 0){
			Instantiate(bullet, transform.position, transform.rotation) as GameObject;
		}
	}
}
