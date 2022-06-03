using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Story : MonoBehaviour
{
    private PlayerData PD;
    private Player P;
    public string stateandcash;
    public string cashandjob;
    public string jobandplace;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (RandomData.cashN <= 3 && RandomData.stateN >= 3)
        {
            stateandcash = "You tried to go big, but ended up going down";
        }
        else if (RandomData.cashN >= 3 && RandomData.stateN >= 3)
        {
            stateandcash = "You went big after going to a big place";
        }
        else if (RandomData.cashN <= 3 && RandomData.stateN <= 3 && RandomData.cashN > 1)
        {
            stateandcash = "You went to live a normal life with a normal house";
        }
        else if (RandomData.cashN == 1 && RandomData.stateN <= 3)
        {
            stateandcash = "You are broke and live in a semi decent state";

        }
        else if (RandomData.cashN >= 3 && RandomData.stateN <= 3)
        {
            stateandcash = "You wanted to live in a small area, but still pampered yourself with your own cash";
        }

        if(RandomData.cashN >= 3 && RandomData.occupancyN >= 3)
        {
            cashandjob = "You have a nice stable job, and good amount of saved money";
        }else if(RandomData.cashN >=3 && RandomData.occupancyN <= 3)
        {
            cashandjob = "You have been working the same job for a bit, but happy at money saved away";
        }else if(RandomData.cashN <= 3 && RandomData.occupancyN >= 3)
        {
            cashandjob = "You have a good job, but are a bit spend happy with it";
        }else if(RandomData.cashN<= 3 && RandomData.occupancyN <= 3)
        {
            cashandjob = "You don't have a good job, and haven't saved up much";
        }





    }
    public void loadtext(){
        
        text.text = "Your name is , " + PlayerData.NameCheck+","+cashandjob+", and with your cash ,"+stateandcash;
    }
}
