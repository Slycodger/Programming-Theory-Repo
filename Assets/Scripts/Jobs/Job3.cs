using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Job3 : Job5
{

    private void Update()
    {
        P = GameObject.Find("Player").GetComponent<Player>();
    }
    public new void Work()
    {
        Player.Money += 10000 * RandomData.stateN;


    }
}


