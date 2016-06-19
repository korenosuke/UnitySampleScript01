using UnityEngine;
using System.Collections;

public class testshot : MonoBehaviour {

		public GameObject BulletObject;
		public Transform MuzzleObject;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			if(Input.GetKey(KeyCode.Z)){
			GameObject b = GameObject.Instantiate (BulletObject, MuzzleObject.position, MuzzleObject.rotation) as GameObject;
				Vector3 force;
				force = this.gameObject.transform.forward * 3000;
				b.transform.GetComponent<Rigidbody> ().AddForce (force);
				b.transform.position = MuzzleObject.position;

			}
		}
}

