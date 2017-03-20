using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSession : MonoBehaviour
{

    public GlobalEvents events;

    public int nbChordTest = 5;
    private bool waitingFor;
    private bool downTest;
    private float waitTime;

    public string testTxt;

    public IEnumerator Session()
    {
        events.yFix = events.myo.transform.forward.y;
        events.chordSucceed = 0;
        events.testingState = true;
        waitingFor = true;
        downTest = false;

        for (int i = 0; i < nbChordTest; i++)
        {
            events.timingLeft = 2.0f;
            waitTime = Random.Range(1.0f, 3.0f);

            while (waitingFor)
            {
                if (events.timingLeft < 0)
                {
                    waitingFor = false;
                }
                else
                {
                    testTxt = "Jouez un accord";
                    if (events.myo.transform.forward.y < (events.yFix - 0.12))
                    {
                        downTest = true;
                    }
                    if (downTest)
                    {
                        if (events.myo.transform.forward.y > (events.yFix - 0.08))
                        {
                            events.chordSucceed++;
                            downTest = false;
                            waitingFor = false;
                        }
                    }
                }
                yield return new WaitForSeconds(0);
            }
            testTxt = "";
            waitingFor = true;
            yield return new WaitForSeconds(waitTime);
        }
        events.testingState = false;
        yield return new WaitForSeconds(1);
        testTxt = "Accords réussis : " + events.chordSucceed + "/" + nbChordTest;
    }
}
