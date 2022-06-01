using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class PlayerData : MonoBehaviour
{
    public Text NameSave;
    private int CheckAmountOfSaves;
    public static string NameCheck;
    private GetInfor GI;
    private RandomData RD;
    public string test;
    public string Name;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        CheckAmountOfSaves = FindObjectsOfType<PlayerData>().Length;

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            RD = GameObject.Find("GameManager").GetComponent<RandomData>();
            GI = GameObject.Find("InformationAboutPlayer").GetComponent<GetInfor>();
            Save();

        }

    }
    private void Update()
    {

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            NameSave = GameObject.Find("Text").GetComponent<Text>();
        }

        if (CheckAmountOfSaves > 1)
        {
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            RD = GameObject.Find("GameManager").GetComponent<RandomData>();
        }

    }
    [System.Serializable]
    class SaveData
    {
        public string Name;
        public int State;
        public int Cash;
        public int Occupancy;
        public int Place;
        public bool HaveSaved;
    }

    public void Save()
    {
        SaveData data = new SaveData();


        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
            data.State = RD.stateN;
            data.Cash = RD.cashN;
            data.Occupancy = RD.occupancyN;
            data.Place = RD.partN;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
        }
        data.Name = NameSave.text;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            if (SceneManager.GetActiveScene().buildIndex > 1)
            { 
                RD.stateN = data.State;
                RD.cashN = data.Cash;
                RD.occupancyN = data.Occupancy;
                RD.partN = data.Place;

        }
            NameCheck = data.Name;
        }
    }
}
