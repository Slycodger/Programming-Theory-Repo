using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddButton : MonoBehaviour
{
    private PlayerData PD;
    private Button Button;
    public bool Load;
    public bool Save;
    // Start is called before the first frame update
    void Start()
    {
        Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        PD = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        if (Save)
        {
            Button.onClick.AddListener(PD.Save);
        }
        if (Load)
        {
            Button.onClick.AddListener(PD.Load);
        }

    }
}
