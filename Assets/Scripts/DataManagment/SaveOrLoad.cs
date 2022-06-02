using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOrLoad : MonoBehaviour
{

    private PlayerData PD;
    public GameObject save;
    public GameObject load;
    public GameObject LoadSaveddata;
    public GameObject Infor;
    public GameObject Button;

    public void Start()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        Infor.gameObject.SetActive(false);
        load.gameObject.SetActive(false);
        Button.gameObject.SetActive(false);
    }

    public void Save()
    {
        PD.Save();
        load.gameObject.SetActive(true);
        save.gameObject.SetActive(false);
        LoadSaveddata.gameObject.SetActive(false);

    }
    public void Load()
    {
        PD.Load();
        load.gameObject.SetActive(false);
        Infor.gameObject.SetActive(true);
        Button.gameObject.SetActive(true);

    }
    public void LoadSavedData()
    {
        save.gameObject.SetActive(false);
        load.gameObject.SetActive(true);
        LoadSaveddata.gameObject.SetActive(false);

    }

}
