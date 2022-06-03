using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GetInfor : MonoBehaviour
{
    private TextMeshProUGUI text;
    private PlayerData PD;
    private RandomData RD;
    private Player P;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        RD = GameObject.Find("GameManager").GetComponent<RandomData>();
        P = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = "Information"+"\n" + "Name : " + PlayerData.NameCheck+"\n"+"State :"+Player.State+"\n"+"Cash :"+P.CashN+"\n"+"Occupancy :"+Player.Job+"\n"+"Part :"+Player.Place+"\n"+"Happiness :"+Player.HappyLevel;
    }
}
