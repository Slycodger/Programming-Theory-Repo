using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnScene : MonoBehaviour
{
    private PlayerData PD;
    public static int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        

    }
    private void Update()
    {
        time ++;
        if (time <= 10)
        {
            PD.Load();
        }
    }
    // Update is called once per frame
}
