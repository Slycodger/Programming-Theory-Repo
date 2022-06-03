using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomData : Player
{
    //INHERTANCE
    public string[] Places;
    public string[] Cash;
    public string[] Occupancy;
    public string[] City;

   [SerializeField] public static int stateN;
   [SerializeField] public static int cashN;
    [SerializeField]public static int occupancyN;
    [SerializeField]public static int partN;

    public static string state;
    public static int cash;
    public static string occupancy;
    public static string part;

    private int minCash;
    private int minOccupancy;
    private int minCity;

    public int Randomized;
    public int I = 0;
    private PlayerData PD;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();

        if(Randomized == 0)
        {
            RandomStuff();
        }
        DeCode();

        if (I < 10)
        {
            I++;
        }
        if (I <= 5)
        {
            Player.Money = cash;
        }

        
        Player.State = state;
        Player.Place = part;
        Player.Job = occupancy;
    }
    public void RandomStuff()
    {
        stateN = Random.Range(1, Places.Length);

        if (stateN >= 3)
        {
            minCash = 2;
        }
        else if (stateN <= 2)
        {
            minCash = 1;
        }

        cashN = Random.Range(minCash, Cash.Length);

        if (cashN >= 3)
        {
            minOccupancy = 2;
        }
        else if (cashN <= 2)
        {
            minOccupancy = 1;
        }

        occupancyN = Random.Range(1, 2);

        if (occupancyN >= 3)
        {
            minCity = 2;
        }
        else if (occupancyN <= 2)
        {
            minCity = 1;
        }

        partN = Random.Range(minCity, City.Length);

        Randomized = 1;
    }
    public void DeCode()
    {   
        //Encapsulation
        //Preventing variables from being to high or to low what is normal by returning null

        if (stateN == 5)
        {
            state = "California";

        }
        else if (stateN == 4)
        {
            state = "Texas";

        }
        else if (stateN == 3)
        {
            state = "New York";

        }
        else if (stateN == 2)
        {
            state = "Florida";
        }
        else if (stateN == 1)
        {
            state = "Illinois";
        }
        else if(stateN <= 0)
        {
            state = "Null";
        }else if(stateN >= 6)
        {
            state = "Null";
        }




        if (cashN == 5)
        {
            cash = 500000;

        }
        else if (cashN == 4)
        {
            cash = 80000;

        }
        else if (cashN == 3)
        {
            cash = 50000;

        }
        else if (cashN == 2)
        {
            cash = 30000;
        }
        else if (cashN == 1)
        {
            cash = 10000;
        }
        else if (cashN <= 0)
        {
            cash = 0;
        }
        else if(cashN >= 6)
        {
            cash = 0;
        }




        if (occupancyN >= 5)
        {
            occupancy = "Surgeon";

        }
        else if (occupancyN == 4)
        {
            occupancy = "Lawyer";

        }
        else if (occupancyN == 3)
        {
            occupancy = "Manager of Subway";

        }
        else if (occupancyN == 2)
        {
            occupancy = "Worker of Subway";
        }
        else if (occupancyN == 1)
        {
            occupancy = "Homeless";
        }
        else if (occupancyN <= 0)
        {
            occupancy = "Null";
        }else if(occupancyN >= 6)
        {
            occupancy = "Null";
        }



        if (partN == 5)
        {
            part = "Upper Class";

        }
        else if (partN == 4)
        {
            part = "Upper Middle Class";

        }
        else if (partN == 3)
        {
            part = "Middle";

        }
        else if (partN == 2)
        {
            part = "Lower";
        }
        else if (partN == 1)
        {
            part = "Streets";
        }
        else if (partN <= 0)
        {
            part = "Null";
        }else if(partN >= 6)
        {
            part = "Null";
        }
    }
}   
