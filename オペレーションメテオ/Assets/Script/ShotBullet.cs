using UnityEngine;
using System.Collections;

public class ShotBullet : MonoBehaviour {

	public GameObject BulletObject;
	public Transform MuzzleObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z)){
			GameObject b = GameObject.Instantiate (BulletObject, MuzzleObject.position, Quaternion.identity) as GameObject;
			Vector3 force;
			force = MuzzleObject.transform.forward * 3000;
			b.transform.GetComponent<Rigidbody> ().AddForce (force);

		}
	}
}
