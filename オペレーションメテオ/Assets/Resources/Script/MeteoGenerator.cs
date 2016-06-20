using UnityEngine;
using System.Collections;

public class MeteoGenerator : MonoBehaviour {

	[SerializeField]
		private GameObject meteo;
	[SerializeField]
		private float interval;

	[SerializeField]
		private float height = 20;
	[SerializeField]
		private float xMin = 0;
	[SerializeField]
		private float xMax = 30;
	[SerializeField]
		private float zMin = 0;
	[SerializeField]
		private float zMax = 30;

	private float time = 0;

	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time >= interval) {
			float x = Random.Range(xMin, xMax);
			float z = Random.Range(zMin, zMax);
			Instantiate(meteo, new Vector3(x, height, z), Quaternion.identity);
			time = 0;
		}
	}
}
