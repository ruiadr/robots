using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	private Player player;
	private bool mouseLeftDown;
	private bool mouseRightDown;

	public void Start () {
		player = GetComponent<Player> ();
		mouseLeftDown = false;
		mouseRightDown = false;
	} // Start ();

	public void Update () {
		// Rotation vers la gauche ?
		if (Input.GetMouseButtonDown (0)) {
			mouseLeftDown = true;
		} else if (Input.GetMouseButtonUp (0)) {
			mouseLeftDown = false;
		}
		player.rotateLeft = mouseLeftDown;

		// Rotation vers la droite ?
		if (Input.GetMouseButtonDown (1)) {
			mouseRightDown = true;
		} else if (Input.GetMouseButtonUp (1)) {
			mouseRightDown = false;
		}
		player.rotateRight = mouseRightDown;
	} // Update ();

}; // PlayerControl;
