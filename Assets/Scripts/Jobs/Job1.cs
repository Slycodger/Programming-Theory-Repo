using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Job1:Job5
{

    private void Update()
    {
        P = GameObject.Find("Player").GetComponent<Player>();
    }
    public new void Work()
    {
        Player.Money += 1100 * RandomData.stateN;


    }
}

