using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour {

    public Transform[] playerCards;
    public bool[] isPresent;
    public int numPlayers;
	
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RefreshControllers();
        
	}

    void RefreshControllers()
    {
        numPlayers = 0;
        foreach (string s in Input.GetJoystickNames())
        {
            if (s != string.Empty) numPlayers++;
        }
        if (numPlayers > 8) numPlayers = 8;

        isPresent = new bool[] { false, false, false, false, false, false, false, false };

        if (numPlayers > 0)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                isPresent[i] = true;
            }
        }

        for (int j = 0; j < 2; j++)
        {
            playerCards[j].gameObject.SetActive(isPresent[j]);
        }
    }
}
