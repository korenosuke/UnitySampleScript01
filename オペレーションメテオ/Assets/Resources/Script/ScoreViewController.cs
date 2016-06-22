using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreViewController : MonoBehaviour {

	private static int score;
	private Text text;

	// Use this for initialization
	void Start () {
		score = 0;
		text = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "" + score;
	}

	public static void AddScore(int n) {
		score += n;
	}

}
