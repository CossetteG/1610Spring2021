using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    public int scoreCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount++;
        print(scoreCount);
    }

    void ScoreTest()
    {
        if (scoreCount > 100)
        {
            print("Gold Star for You");
        }
        else
        {
            print("Go for the Gold");
        }
    }
}
