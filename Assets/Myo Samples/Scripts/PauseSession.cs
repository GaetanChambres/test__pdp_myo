using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSession : MonoBehaviour
{

    public GlobalEvents events;

	private bool pauseBoolean = false;

	public void PauseClick()
	{
		if (events.startTimer == true)
			pauseBoolean = false;
		pauseBoolean = !pauseBoolean;

		if (pauseBoolean == true)
			Pause ();
		else if (pauseBoolean == false)
			UnPause ();
	}

    public void Pause()
    {
        events.startTimer = false;
        events.pause = true;
    }

    public void UnPause()
    {
        events.startTimer = true;
        events.pause = false;
    }
}
