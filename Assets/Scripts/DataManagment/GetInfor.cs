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
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        RD = GameObject.Find("GameManager").GetComponent<RandomData>();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Information"+"\n" + "Name : " + PlayerData.NameCheck+"\n"+"State :"+RD.state+"\n"+"Cash :"+RD.cash+"\n"+"Occupancy :"+RD.occupancy+"\n"+"Part :"+RD.part;
    }
}
