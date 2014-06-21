using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool _rotateLeft;
	private bool _rotateRight;
	private int torque;

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
		torque = rotateRight ? -50 : rotateLeft ? 50 : 0;
	} // Update ();

	public void FixedUpdate () {
		rigidbody2D.AddTorque (torque);
	} // FixedUpdate ();

}; // Player;
