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

    //Encapsulation
    //Even if variable is changed the moment load is activated they will return to normal,
    //load is called after 2 secounds of every scene for all the scenes
    [System.Serializable]
    class SaveData
    {
        public string Name;
        public string State;
        public int Cash;
        public string Occupancy;
        public string Place;
        public  bool HaveSaved;
        public int StateN;
        public int CashN;
        public int OccupancyN;
        public int PlaceN;

    }

    public void Save()
    {
        SaveData data = new SaveData();



        
        data.State = Player.State;
        data.Cash = Player.Money;
        data.Occupancy = Player.Job;
        data.Place = Player.Place;
        data.StateN = RandomData.stateN;
        data.CashN = RandomData.cashN;
        data.OccupancyN = RandomData.occupancyN;
        data.PlaceN = RandomData.partN;
        

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
            {
                Player.State = data.State;
                Player.Money = data.Cash;
                Player.Job = data.Occupancy;
                Player.Place = data.Place;
                Player.Name = data.Name;
                RandomData.stateN = data.StateN;
                RandomData.cashN = data.CashN;
                RandomData.occupancyN = data.OccupancyN;
                RandomData.partN = data.PlaceN;

                NameCheck = data.Name;

                Debug.Log("Loaded");
            }
        }
    }
}
    

