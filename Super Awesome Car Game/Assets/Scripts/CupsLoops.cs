using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishwashingLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int cupsInTheSink = 4;
        int platesInTheSink = 3;
        int chopsticksInTheSink = 6;
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup");
            cupsInTheSink--;
        }

        bool shouldContinue = false;

        do
        {
            Debug.Log("I'm washing plates");
        } 
        while (shouldContinue == true);

        for (int i = 0; i < chopsticksInTheSink; i--)
        {
            Debug.Log("I'm also washing chopstick number" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
