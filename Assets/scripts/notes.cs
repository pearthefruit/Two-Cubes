using UnityEngine;
using System.Collections;

public class notes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position is object space forward, not global forward which doesn't rotate
		if (Input.GetKey (KeyCode.A) ) {
			transform.position += transform.forward * Time.deltaTime;
		}
	}
}
