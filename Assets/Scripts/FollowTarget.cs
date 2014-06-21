using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {
	
	public Transform target;
	public float zValue = -10.0f;
	
	public void Update () {
		if (target == null) return;
		gameObject.transform.position = new Vector3 (
			target.transform.position.x,
			target.transform.position.y,
			zValue
		);
	} // Update ();
	
}; // FollowTarget;
