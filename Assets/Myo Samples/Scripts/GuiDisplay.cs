using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GuiDisplay : MonoBehaviour {

	public GlobalEvents events;
	public TestSession testSession;

	public static bool startButton;
	public static bool stopButton;
	public static bool testButton;

	private int nbChordDisplay;

	public string userName;

	void OnGUI () 
	{

		GUI.skin.label.fontSize = 20;

		userName = GUI.TextArea(new Rect(Screen.width - 80, 10, 200, 20), userName, 255);

		/* Creation of our rectangle, use it as button for different functions : start/stop/test */
		Rect posStart = new Rect (Screen.width / 2 - 50, Screen.height - 50, 100, 50);
		Rect posTest = new Rect (Screen.width / 4, Screen.height - 50, 100, 50);
		Rect posStop = new Rect (Screen.width - Screen.width / 4, Screen.height - 50, 100, 50);

		/* Rectangle for the test text */
		Rect testRect = new Rect (Screen.width / 2, Screen.height / 4, 150, 80);

		GuiDisplay.startButton = GUI.Button (posStart, "START");
		GuiDisplay.stopButton = GUI.Button (posStop, "STOP");
		GuiDisplay.testButton = GUI.Button (posTest, "TEST");

		GUI.Label (new Rect (12, 8, Screen.width, Screen.height),
			"Accord joués : " + events.nbChord + "\n" +
			"Accord test : " + events.chordSucceed + "/" + testSession.nbChordTest + "\n" +
			"Temps de jeu : " + events.time + "\n" +
			"P : Pause\nM : Reprendre\nSPACE : START\nF : Précision accrue");

		/* Nothing to show  while test isnt runing */
		GUI.Label (testRect, "" + testSession.testTxt);
	}

}
