using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void startButton()
    {
        SceneManager.LoadScene(sceneName: "Demo");
    }
    public void exitButton()
    {
        Application.Quit();
    }
}