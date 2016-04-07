﻿using UnityEngine;
using System.Collections;

public class Rack : MonoBehaviour {

	public Material[] solids;
	public Material[] stripes;
	public GameObject[] balls;
	public GameObject leftBall;
	public GameObject rightBall;

	// Use this for initialization
	void Start () {
		ArrayList mats = new ArrayList (solids);
		mats.AddRange(stripes);
		foreach (Material m in mats) {
			Debug.Log(m);
		}

		Material cornerStripe = stripes[Random.Range (0, stripes.Length - 1)];
		Material cornerSolid = solids[Random.Range (0, solids.Length - 1)];
		mats.Remove (cornerSolid);
		mats.Remove (cornerStripe);
		foreach (GameObject go in balls) {
			Material m = (Material) mats[Random.Range(0, mats.Count - 1)];
			go.GetComponent<Renderer>().material = m;
			mats.Remove(m);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
