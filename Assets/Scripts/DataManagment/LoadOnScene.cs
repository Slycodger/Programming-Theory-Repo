using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnScene : MonoBehaviour
{
    public int score = 0;
    private PlayerData PD;
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
        }
    }
    IEnumerator time()
    {
        while (true)
        {
            if (score < 4)
            {
                timeCount();
                yield return new WaitForSeconds(1);
            }
        }
    }

    void timeCount()
    {
        score += 1;
    }
}
