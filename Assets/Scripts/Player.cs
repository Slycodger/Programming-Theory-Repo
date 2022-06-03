using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //INHERITANCE
    public static string Job;
    public static string State;
    public static int Money;
    public static string Place;
    public static string Name;
    [HideInInspector]public int CashN;
    private int CheckAmountOfSaves;
    public static int HappyLevel;
    // Start is called before the first frame update
    void Start()
    {
        CheckAmountOfSaves = FindObjectsOfType<PlayerData>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        CashN = Money;

        DontDestroyOnLoad(this.gameObject);
        
        if(CheckAmountOfSaves >= 2)
        {
            Destroy(gameObject);
        }
        
    }
}
