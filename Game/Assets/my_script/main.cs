using UnityEngine;
using System.Collections;

public class main : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        controler_manager();
	}

    void controler_manager()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(Time.timeScale == 0)
            {
                unpause();
            }
            else
            {
                pause();
            }
            
        }
    }

    void pause()
    {
        GameObject button_pause = GameObject.Find("Button_Pause");
        GameObject button_unpause = GameObject.Find("Button_unPause");
        Time.timeScale = 0;
        //button_unpause.transform.position = new Vector3(94.5f, 704.5f, 0);
        button_unpause.transform.position = new Vector3(94.5f, 1024.5f, 0); // 1920x1080
        button_pause.transform.position = new Vector3(7166, 6436, 0);
    }

    void unpause()
    {
        GameObject button_pause = GameObject.Find("Button_Pause");
        GameObject button_unpause = GameObject.Find("Button_unPause");
        Time.timeScale = 1;
        //button_pause.transform.position = new Vector3(94.5f, 704.5f, 0); //1024x768
        button_pause.transform.position = new Vector3(94.5f, 1024.5f, 0); // 1920x1080
        button_unpause.transform.position = new Vector3(7166, 6436, 0);
    }
}
