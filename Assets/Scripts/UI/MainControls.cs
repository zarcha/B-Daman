using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainControls : MonoBehaviour {
	
	//Find out what button it is
	//public char butType;
	
	//Set ball amounts
	public int balls;
	public int maxBalls;
	public GameObject ballTxt;
	
	//Set of control objects
	public GameObject normFire;
	//public GameObject specFire; this is something not in
	public GameObject reload;
	
	//Set Player
	public GameObject player;
	
	//Set ball prefab
	public GameObject ball;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("BallSpawn");
	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_EDITOR
		if(Input.GetKeyUp(KeyCode.Space))
		{
			ButtonHit('n');
		}	
		if(Input.GetKeyUp(KeyCode.R))
		{
			ButtonHit('r');
		}
		#endif
		
		ballTxt.GetComponent<Text>().text = "Balls: " + balls;
	}
	
	public void ButtonHit(char butType)
	{
		switch(butType)
		{
			case 'n':
				Debug.Log("Normal Fire");
				if(balls > 0)
				{
					GameObject newBall;
					newBall = Instantiate(ball, player.transform.position, player.transform.rotation) as GameObject;
					newBall.transform.position = player.transform.position;
					balls--;
				}
				break;
			case 's':
				//This is for later
				break;
			case 'r':
				balls = maxBalls;
				break;
			default:
				Debug.LogWarning("Not an exceptible type of button!");
				break;
		}
	}
}
