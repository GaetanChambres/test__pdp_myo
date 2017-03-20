using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnexionMyo : MonoBehaviour
{

    public static bool myoConnected = false;

    /* Myo gameobject to connect with */
    public GameObject myo = null;
    
    void Start()
    {
        Debug.Log("lancement connexion!");
        ThalmicHub hub = ThalmicHub.instance;

        /* Access the ThalmicMyo script attached to the Myo object */
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();
        if (!hub.hubInitialized)
        {
            Debug.Log("Cannot contact Myo Connect. Is Myo Connect running?\n" +
                "Press Q to try again.");
            ConnexionMyo.myoConnected = false;
        }

        else if (!thalmicMyo.isPaired)
        {
            Debug.Log("No Myo currently paired.\n");
            ConnexionMyo.myoConnected = false;
        }

        else
        {
            ConnexionMyo.myoConnected = true;
            Debug.Log("myoConnected");
        }
    }
}
