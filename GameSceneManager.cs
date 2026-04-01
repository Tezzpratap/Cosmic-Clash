using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void GameStart(){
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Game Quit");
    }

}
