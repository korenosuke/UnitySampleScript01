using UnityEngine;
using System.Collections;

public class MovePlayerHed : MonoBehaviour {

	private float x;
	private float y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		y += Input.GetAxis("Mouse X") * 20;
		x -= Input.GetAxis("Mouse Y") * 15;

		transform.rotation = Quaternion.Euler (x, y, 0);


	}
}
