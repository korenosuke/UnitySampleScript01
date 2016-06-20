using UnityEngine;
using System.Collections;

public class AccelerateBullet : MonoBehaviour {

	[SerializeField]
	private float yMax;

	[SerializeField]
	private float yMin;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < yMin) {
			Destroy (this.gameObject);
		}

		if (this.transform.position.y > yMax) {
			Destroy (this.gameObject);
		}

	}
}
