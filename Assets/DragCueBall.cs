using UnityEngine;
using System.Collections;

public class DragCueBall : MonoBehaviour {
	
	float startTime;
	Vector3 startPos;
	Rigidbody rb;
	public float factor = 100f;
	public float speedUp = .3f;

	void Update() {
		Vector3 pos = transform.position;
		pos.y = Mathf.Min(-0.1f, pos.y);
		transform.position = pos;
	}

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}
	
	void OnMouseDown() {
		startTime = Time.time;
		startPos = Input.mousePosition;
	}

	void OnMouseUp() {
		float timeElapsed = Time.time - startTime;
		if (timeElapsed < 1) {
			Vector3 endPos = Input.mousePosition;
			Vector3 force = endPos - startPos;
			// weird switching of coords to make it go the right way
			force.z = -force.x;
			force.x = force.y;
			force.y = 0;
			force.Normalize();
			rb.AddForce(force * factor * speedUp / timeElapsed);
		}
	}
}
