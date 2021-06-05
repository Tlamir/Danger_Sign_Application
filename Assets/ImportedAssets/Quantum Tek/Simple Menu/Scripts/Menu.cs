using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
   public GameObject inputFieldName;
   public GameObject inputFieldSurnamne;
    public GameObject inputFieldId;


    public void startButton()
    {
        Debug.Log(inputFieldName.GetComponent<TMP_InputField>().text);
        SceneManager.LoadScene(sceneName: "LabScene");
    }
    public void exitButton()
    {
        Application.Quit();
    }
}
