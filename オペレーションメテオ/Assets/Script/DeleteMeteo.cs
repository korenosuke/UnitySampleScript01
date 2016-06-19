using UnityEngine;
using System.Collections;

public class DeleteMeteo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -10) {
			Destroy (this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "panel"){
			Destroy (this.gameObject);
		}

		if (collision.gameObject.tag == "bullet"){
			Destroy (this.gameObject);
		}

	}

}
