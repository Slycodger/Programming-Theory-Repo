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
        
        if(Player.Money <=3 && Player.State >=3)
        {
            stateandcash = "You tried to go big, but ended up going down";
        }else if(Player.Money>=3 && Player.State >= 3)
        {
            stateandcash = "You went big after going to a big place";
        }else if(Player.Money <=3 && Player.State <= 3)
        {
            stateandcash = "You went to live a normal life with a normal house";
        }else if (Player.Money >= 3 && Player.State <= 3)
        {
            stateandcash = "You wanted to live in a small area, but still pampered yourself with your own cash";
        }





    }
    public void loadtext(){
        
        text.text = "Your name is , " + PlayerData.NameCheck+", and with your cash "+stateandcash;
    }
}
