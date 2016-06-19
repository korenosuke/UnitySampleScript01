using UnityEngine;
using System.Collections;

public class MovePlayerBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			this.transform.position += new Vector3 (0, 0, 0.5f);		
		}

		if (Input.GetKey (KeyCode.S)) {
			this.transform.position += new Vector3 (0, 0, -0.5f);
		}

		if (Input.GetKey (KeyCode.A)) {
			this.transform.position += new Vector3 (-0.5f, 0, 0);
		}

		if (Input.GetKey (KeyCode.D)) {
			this.transform.position += new Vector3 (0.5f, 0, 0);
		}


	}
}
