using UnityEngine;
using System.Collections;

public class DragCueBall : MonoBehaviour {
	
	float startTime;
	Vector3 startPos;
	Rigidbody rb;
	public float factor = 100;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}
	
	void OnMouseDown() {
		startTime = Time.time;
		startPos = Input.mousePosition;
	}

	void OnMouseUp() {
		Vector3 endPos = Input.mousePosition;
		Vector3 force = endPos - startPos;
		force.z = -force.x;
		force.x = force.y;
		force.y = 0;

		Debug.Log (force);
		rb.AddForce(force * factor);
	}
}
