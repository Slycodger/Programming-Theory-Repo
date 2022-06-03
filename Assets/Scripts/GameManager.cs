using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int[] SceneToGo;
    private GameObject Pause;
    private void Update()
    {
        Pause = GameObject.Find("Pause");
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneToGo[0]);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneToGo[1]);
    }
    public void OnWard()
    {
        SceneManager.LoadScene(SceneToGo[2]);
       
    }
    public void Resume()
    {
        Pause = GameObject.Find("Pause");
        Pause.gameObject.SetActive(false);
    }
    public void GameOn()
    {
        SceneManager.LoadScene(SceneToGo[3]);
    }
    public void ExitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
