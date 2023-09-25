using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstructions = "Move the player using the W, A, S, and D keys";
    public string cowbellWarning = "Not enough cowbell!!";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
        Debug.LogWarning(cowbellWarning);
    }
}
