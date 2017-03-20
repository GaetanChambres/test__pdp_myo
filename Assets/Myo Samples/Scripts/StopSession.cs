using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSession : MonoBehaviour
{

    public GlobalEvents events;

    public void Session()
    {
        events.startTimer = false;

        /* Send data to our server when stop is pressed */
        events.post.Send("Alice", events.nbChord);

		events.nbChord = 0;
		events.time = 0;
    }
}
