using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	void Update() {
		Vector3 pos = transform.position;
		pos.y = Mathf.Min(-0.1f, pos.y);
		transform.position = pos;
	}
}
