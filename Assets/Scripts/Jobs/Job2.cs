using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Job2 : Job5
{

    private void Update()
    {
        P = GameObject.Find("Player").GetComponent<Player>();
    }
    public new void Work()
    {
        Player.Money += 5000 * RandomData.stateN;


    }
}


