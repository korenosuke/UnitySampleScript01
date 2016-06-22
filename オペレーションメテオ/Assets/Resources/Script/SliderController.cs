using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderController : MonoBehaviour {

	[SerializeField]
		private GameObject slider_obj;
	[SerializeField]
		private GameObject timer_obj;

	private Slider slider;
	private Timer timer;

	// Use this for initialization
	void Start () {
		slider = slider_obj.GetComponent<Slider>();
		timer = timer_obj.GetComponent<Timer>();
		slider.value = slider.maxValue = timer.GetTimeLimit();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = timer.GetRestTime();
	}
}
