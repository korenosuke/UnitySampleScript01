using UnityEngine;
using System.Collections;

public class AccelerateBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -10) {
			Destroy (this.gameObject);
		}
	}
}
