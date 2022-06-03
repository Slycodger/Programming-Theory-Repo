using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promotion : Player
{
    public static int Happy = 5;
    // Start is called before the first frame update

    private void Start()
    {
        Happy = PlayerPrefs.GetInt("Happy");
    }
    private void Update()
    {
        PlayerPrefs.SetInt("Happy", Happy);
        Happy = PlayerPrefs.GetInt("Happy");
        Player.HappyLevel = PlayerPrefs.GetInt("Happy");
    }
    public static void NewJob()
    {
        if (Player.Money > 20000 * RandomData.occupancyN)
        {
            RandomData.occupancyN++;
            Player.Money -= 20000 * RandomData.occupancyN;
        }
        else
        {
            Debug.Log("Need More Money");
        }
    }
    public static void IncreaseHappy()
    {
        if (Happy < 5)
        {
            Happy++;
            Player.Money -= 1000;
        }
        if (Happy < 0)
        {
            Debug.Log("No negatives");
        }

    }
    public static void Move()
    {
        if (RandomData.occupancyN > 3 && Player.Money >= RandomData.cashN * RandomData.occupancyN && RandomData.stateN != 5)
        {
            RandomData.stateN++;
            Player.Money -= 10000 * RandomData.occupancyN * RandomData.stateN * 10;
        }
        else
        {
            Debug.Log("Max State or not enough Money");
        }
    }
    public static void MoveUp()
    {
        if (RandomData.stateN > 3 && Player.Money > 10000 * RandomData.occupancyN && RandomData.occupancyN > 2)
        {
            RandomData.partN++;
            Player.Money -= 10000 * RandomData.occupancyN * 10;
        }
        else
        {
            Debug.Log("Not enough money or max place");
        }
    }
}
