using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	[SerializeField]
		private int TIME_LIMIT;

	private float time;


	// Use this for initialization
	void Start () { this.time = 0;	}
	
	// Update is called once per frame
	void Update () {
		this.time += Time.deltaTime;
		if(IsTimeOver()) Time.timeScale = 0.0f;
	}

	public bool IsTimeOver() { return TIME_LIMIT < this.time;	}

	public void TimeRecovery(float time) {this.time -= time;}

	public void TimeReset() { this.time = 0; }

	public float GetTime() { return this.time; }
	public float GetRestTime() { return this.TIME_LIMIT - this.time; }
	public float GetTimeLimit() { return this.TIME_LIMIT; }

}
