using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnScene : MonoBehaviour
{
    public int score = 0;
    private PlayerData PD;
    private bool Loaded = false;
    public void Start()
    {
        StartCoroutine(time());
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }

    public void Update()
    {
        if (score >= 2)
        {
            PD.Load();
            Loaded = true;
        }
        if (Loaded)
        {
            score = 0;
        }
    }
    IEnumerator time()
    {
        while (true)
        {
                timeCount();
                yield return new WaitForSeconds(1);
            
        }
    }

    void timeCount()
    {
        if (!Loaded)
        {
            score += 1;
        }
    }
}
