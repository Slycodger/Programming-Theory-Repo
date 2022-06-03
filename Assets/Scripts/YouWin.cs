using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YouWin : MonoBehaviour
{
    public GameObject Congrats;
    private int time;
    // Update is called once per frame
    private void Start()
    {
        Congrats.gameObject.SetActive(false);
    }
    void Update()
    {
        if(Player.Money > 10000000 && RandomData.occupancyN == 5 && RandomData.partN == 5 && RandomData. stateN == 5)
        {
            Congrats.gameObject.SetActive(true);
            StartCoroutine(timer());
        }

        if (time >= 5)
        {
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator timer()
    {
        while (true)
        {
            TimeCount();
            yield return new WaitForSeconds(1);
        }
    }
    public void TimeCount()
    {
        time++;
    }
}
