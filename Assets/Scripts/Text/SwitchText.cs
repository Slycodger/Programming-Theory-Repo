using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SwitchText : MonoBehaviour
{
    public TextMeshProUGUI TextToChange;
    public string NewText;
    public Button buttonChanges;


    public void ClickAndSwitch()
    {
        TextToChange.text = NewText;

        buttonChanges.onClick.RemoveAllListeners();
        buttonChanges.onClick.AddListener(NextScene);    

    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Player.Money = 0;
    }
}
