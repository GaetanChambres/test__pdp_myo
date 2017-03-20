using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DynamicTextDisplay : MonoBehaviour {

	public GlobalEvents events;

	public Text timeText;
	public Text chordsText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeText.text = events.time.ToString ();
		chordsText.text = events.nbChord.ToString ();
	}
}
