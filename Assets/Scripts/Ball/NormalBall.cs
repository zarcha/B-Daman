using UnityEngine;
using System.Collections;

public class NormalBall : MonoBehaviour {
	
	public float timer = 0.0f;
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		GetComponent<Rigidbody>().AddForce(-player.transform.right * 1000);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		
		if(timer >= 10)
		{
			Destroy(gameObject);
		}
	}
}
