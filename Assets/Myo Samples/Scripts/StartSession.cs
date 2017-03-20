using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSession : MonoBehaviour
{

    public GlobalEvents events;

    public void Session()
    {
        /* Reset timer */
        events.startTimer = false;
        events.time = 0;
		events.timeSaved = 0;

		/* Reset pause */
		events.pause = false;

        /* Get actual Y position, save it and use it to see how far myo is moving */
        events.yFix = events.myo.transform.forward.y;

        events.startTimer = true;
        events.down = false;

        /* Reset chord counter*/
        events.nbChord = 0;
		events.nbChordSaved = 0;

    }
}
