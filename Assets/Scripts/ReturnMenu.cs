using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnMenu : MonoBehaviour
{
    public Obi.ObiEmitter firstChemical;
    public Obi.ObiEmitter secondEmitter;
    public bool experimentStarted = false;
    public Text pointText;
    public int point = 0;



    private void Start()
    {
        firstChemical.speed = 0;
        secondEmitter.speed = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
      
        }

        if (Input.GetKey("r"))
        {
            if (!experimentStarted)
            {
                point += 10;
            }
            
            pointText.text = point.ToString();
            firstChemical.speed = 1;
            secondEmitter.speed = 1;
            experimentStarted = true;
         
        }
        if (Input.GetKey("t"))
        {
            
            SceneManager.LoadScene(sceneName: "LabScene");
        }
    }

   
}
