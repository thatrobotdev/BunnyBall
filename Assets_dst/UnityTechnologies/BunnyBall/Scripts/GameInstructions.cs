using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstructions = "Move the player using the W, A, S, and D keys";
    public string cowbellWarning = "Not enough cowbell!!";

    byte sampleByte; // 0-255
    int sampleInt; // ~-2,000,000 to ~2,000,000
    float sampleFloat; // // 1.14, 98,888

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
        Debug.LogWarning(cowbellWarning);
    }
}
