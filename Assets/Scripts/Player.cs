using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool _rotateLeft;
	private bool _rotateRight;
	private Vector3 torque;

	void Start () {
		rotateLeft = false;
		rotateRight = false;
	} // Start ();

	public bool rotateLeft {
		get {return _rotateLeft;}
		set {_rotateLeft = value;}
	} // rotateLeft;

	public bool rotateRight {
		get {return _rotateRight;}
		set {_rotateRight = value;}
	} // rotateRight;

	void Update () {
		torque = new Vector3 (
			0.0f,
			0.0f,
			rotateRight ? -1.0f : rotateLeft ? 1.0f : 0.0f
		);
	} // Update ();

	public void FixedUpdate () {
		rigidbody.AddTorque (torque);
	} // FixedUpdate ();

}; // Player;
