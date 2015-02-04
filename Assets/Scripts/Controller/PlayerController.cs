using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 15.0F;
	public float rotateSpeed = 3.0F;
	float curSpeed;
	
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		Vector3 forward = transform.TransformDirection(transform.forward);
		#if UNITY_ANDROID
		curSpeed = speed * Input.acceleration.x;
		#endif
		#if UNITY_EDITOR
		curSpeed = speed * Input.GetAxis("Horizontal");
		#endif
		controller.SimpleMove(forward * curSpeed);
	}
}
