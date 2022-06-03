using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetData : MonoBehaviour
{
    private PlayerData PD;
    private RandomData RD;
    private Player P;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        RD = GameObject.Find("GameManager").GetComponent<RandomData>();
        P = GameObject.Find("Player").GetComponent<Player>();
    }

    public void RestartData() {
        RD.Randomized = 0;
        Player.Money = 0;
        PD.NameSave.text = "";
        PD.Save();
        SceneManager.LoadScene(0);
    }
}
