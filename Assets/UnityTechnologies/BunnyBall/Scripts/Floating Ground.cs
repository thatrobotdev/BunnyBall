using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FloatingGround : MonoBehaviour
{
    public bool SpotA;
    public bool SpotB;
    public float Speed = 1;
    void Start()
    {
        SpotA = true;
    }

    // Update is called once per frame
    void Update()
    {
        AtoB();
        BtoA();
    }

    void AtoB()
    {
        if (SpotA)
        {
            transform.Translate(transform.right * Time.deltaTime * Speed);
            if(transform.position.x <= -28)
            {
                SpotA = false;
                SpotB = true;
            }
        }
    }
    void BtoA()
    {
        if (SpotB)
        {
            transform.Translate(-transform.right * Time.deltaTime * Speed);
            if (transform.position.x >= -11.5f)
            {
                SpotA = true;
                SpotB = false;
            }
        }
    }
}
