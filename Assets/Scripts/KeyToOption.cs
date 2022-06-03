using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToOption : MonoBehaviour
{
    public GameObject Infor;
    public GameObject Work;
    public Job1 work1;
    public Job2 work2;
    public Job3 work3;
    public Job4 work4;
    public Job5 work5;
    private PlayerData PD;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        Infor.gameObject.SetActive(true);
        Work.gameObject.SetActive(false);
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name == "GameManager")
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Infor.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2)&&Promotion.Happy>0)
            {
                Work.gameObject.SetActive(true);

                PD.Save();

                Promotion.Happy--;
                if(RandomData.occupancyN == 1)
                {
                    work1.Work();
                }else if(RandomData.occupancyN == 2)
                {
                    work2.Work();
                }else if(RandomData.occupancyN == 3)
                {
                    work3.Work();
                }else if(RandomData.occupancyN == 4)
                {
                    work4.Work();
                }else if(RandomData.occupancyN == 5)
                {
                    work5.Work();
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha3) && Promotion.Happy<5 )
            {
                Promotion.IncreaseHappy();
                PD.Save();

            }

            if (Input.GetKeyDown(KeyCode.Alpha4)&&RandomData.occupancyN<5)
            {

                Promotion.NewJob();
                PD.Save();
            }
            if (Input.GetKeyDown(KeyCode.Alpha5)&& RandomData.stateN <5)
            {
                Promotion.Move();
                PD.Save();
            }
            if (Input.GetKeyDown(KeyCode.Alpha6) && RandomData.partN<5)
            {
                Promotion.MoveUp();
                PD.Save();
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                PD.Load();
            }
        }
        if (gameObject.name != "GameManager")
        {
            if (Input.GetKey(KeyCode.Alpha7))
            {
                gameObject.SetActive(false);
            }
        }
    }
    void Save()
    {
        PD.Save();
        Debug.Log("Saved");
    }

}

