using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultViewController : MonoBehaviour {

	[SerializeField]
		private GameObject timer_obj;
	[SerializeField]
		private GameObject player_obj;

	private Text text;
	private Timer timer;
	private PlayerController player;

	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text>();
		player = player_obj.GetComponent<PlayerController>();
		text.color = new Color(1f, 1f, 1f, 0f);
		timer = timer_obj.GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.IsTimeOver()) {
			text.text = "GameClear !!";
			text.color = new Color(0f, 1f, 0f, 1f);
			foreach(GameObject obj in GameObject.FindGameObjectsWithTag("meteo"))
				Destroy(obj);
		}	else if(player.IsGameOver()) {
			text.text = "GameOver !!";
			text.color = new Color(1f, 0f, 0f, 1f);
			foreach(GameObject obj in GameObject.FindGameObjectsWithTag("meteo"))
				Destroy(obj);
		}
	}
}
