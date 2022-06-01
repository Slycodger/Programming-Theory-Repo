using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    private PlayerData PD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }

    public void RestartData() {
        PlayerData.NameCheck = "";
        PlayerData.NameSave.text = "";
        
        
    }
}
