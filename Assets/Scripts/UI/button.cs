using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public string butType;
	
	void OnMouseDown()
	{
		transform.parent.GetComponent<MainControls>().ButtonHit(butType[0]);
	}
}
