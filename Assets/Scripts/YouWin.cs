using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YouWin : MonoBehaviour
{
    public GameObject Congrats;
    private float timer;
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

            timer = Time.deltaTime;
        }
        if(timer > 20)
        {
            SceneManager.LoadScene(0);
        }
    }
}
