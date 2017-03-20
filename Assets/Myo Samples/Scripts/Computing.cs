using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computing : MonoBehaviour
{

    public GlobalEvents events;

    /* First move, the arm need to go down from this amount */
    public float moveDown; 

    /* The arm need to go up from this amount */
    public float moveUp;

    /* This amount corresponds to an ample gesture */
    public float downAmount = 0.12f;
    public float upAmount = 0.08f;

    /* This amount corresponds to a precise gesture */
    public float downAmountFast = 0.08f;
    public float upAmountFast = 0.04f; 

    public void Compute()
    {
        if (events.fast)
        {
            moveDown = downAmountFast;
            moveUp = upAmountFast;
        }
        else
        {
            moveDown = downAmount;
            moveUp = upAmount;
        }

        /* Check if we play a chord, precise or ample, depends of the mode*/
        if (events.startTimer)
        {
            if (events.myo.transform.forward.y < (events.yFix - moveDown))
            {
                events.down = true;
            }
            if (events.down)
            {
                if (events.myo.transform.forward.y > (events.yFix - moveUp))
                {
                    events.nbChord++;
                    events.down = false;
                }
            }
        }
    }
}
