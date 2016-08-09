using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class MenuSelector : MonoBehaviour {

    public Texture2D boxbg;
    public string SceneOne;
    public string SceneOneName  = "Level One";
    public string SceneTwo;
    public string SceneTwoName  = "Level Two";
    public string SceneThree;
    public string SceneThreeName = "Level Three";
    public string SceneFour;
    public string SceneFourName = "Level Four";
    public string SceneFive;
    public string SceneFiveName = "Level Five";



    void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 8 - 50, Screen.height / 4 - 10, Screen.width, Screen.height));
        GUI.Box(new Rect(0, 0, 180, 250), boxbg);
        if (GUI.Button(new Rect(10, 10, 150, 30), SceneOneName))
        {
            SceneManager.LoadScene(SceneOne);
        }
        if (GUI.Button(new Rect(10, 50, 150, 30), SceneTwoName))
        {
            SceneManager.LoadScene(SceneTwo);
        }
        if (GUI.Button(new Rect(10, 90, 150, 30), SceneThreeName))
        {
            SceneManager.LoadScene(SceneThree);
        }
        if (GUI.Button(new Rect(10, 130, 150, 30), SceneFourName))
        {
            SceneManager.LoadScene(SceneFour);
        }
        if (GUI.Button(new Rect(10, 170, 150, 30), SceneFiveName))
        {
            SceneManager.LoadScene(SceneFive);
        }

        if (GUI.Button(new Rect(10, 210, 150, 30), "Quit"))
        {
            Application.Quit();
        }
        GUI.EndGroup();
    }
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("SceneOne");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("SceneTwo");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("SceneThree");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("SceneFour");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("TestScene");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
