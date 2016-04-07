using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	void Start() {
		transform.rotation = Quaternion.Euler (Random.Range (0, 360), 
		                                       Random.Range (0, 360), 
		                                       Random.Range (0, 360));
	}
	
	void Update() {
		Vector3 pos = transform.position;
		pos.y = Mathf.Min(-0.1f, pos.y);
		transform.position = pos;
	}
}
