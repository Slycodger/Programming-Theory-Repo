using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnScene : MonoBehaviour
{
    private PlayerData PD;
    // Start is called before the first frame update
    void Start()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();


    }

    // Update is called once per frame
    void Update()
    {
        PD.Load();
    }
}
