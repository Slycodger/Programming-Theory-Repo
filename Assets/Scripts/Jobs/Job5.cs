using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job5 : MonoBehaviour
{
    //ABSTRACTION
    public Player P;
    public PlayerData PD;

    private void Start()
    {
    }
    private void Update()
    {
        P = GameObject.Find("Player").GetComponent<Player>();
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();


    }
    public void Work()
    {
        Player.Money += 20000 * RandomData.stateN;



    }
}
