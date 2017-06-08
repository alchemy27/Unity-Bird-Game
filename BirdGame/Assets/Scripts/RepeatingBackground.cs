using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

	// reference the box
	private BoxCollider2D groundCollider;
	public float groundHorizontalLength;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent <BoxCollider2D> ();
		// Store the horizontal length
		groundHorizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		// will check if background is scrolled to full length
		if (transform.position.x < -groundHorizontalLength) {
			RepositionBackground ();
		}
	}

	private void RepositionBackground() {
		// Calculate how far the background has to move
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
