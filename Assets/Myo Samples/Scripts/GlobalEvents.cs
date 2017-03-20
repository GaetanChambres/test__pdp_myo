using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEvents : MonoBehaviour
{
    public PostURL post;
    public StartSession startSession;
    public StopSession stopSession;
    public PauseSession pauseSession;
    public TestSession testSession;
    public Computing computing;

    public GameObject myo = null;

    public int nbChord;
	public int nbChordSaved;
    public int chordSucceed;

    public bool startTimer;
    public float time;
	public float timeSaved;

    public bool pause;

    public float yFix;

    public bool down = false;
    public bool fast = false;

    public bool testingState;
    public float timingLeft;

    void Update()
    {
        ThalmicHub hub = ThalmicHub.instance;

        computing.Compute();

        if (Input.GetKeyDown("q"))
        {
            hub.ResetHub();
        }

        if (Input.GetKeyDown("f"))
        {
            fast = !fast;
        }

        if (GuiDisplay.startButton || Input.GetKeyDown("space"))
        {
            startSession.Session();
        }

        if (GuiDisplay.stopButton || Input.GetKeyDown("s"))
        {
            stopSession.Session();
        }

        if (GuiDisplay.testButton || Input.GetKeyDown("t"))
        {
            StartCoroutine(testSession.Session());
        }

        if (Input.GetKeyDown("p"))
        {
            pauseSession.Pause();
        }

        if (Input.GetKeyDown("m"))
        {
            pauseSession.UnPause();
        }

        /* Update timer */
        if (startTimer)
        {
            time += Time.deltaTime;
        }

        /* Update time left to play a chord */ 
        if (testingState)
        {
            timingLeft -= Time.deltaTime;
        }
    }
}
