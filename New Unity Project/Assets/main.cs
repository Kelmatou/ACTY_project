using UnityEngine;
using System.Collections;

public class main : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        GameObject text = GameObject.Find("Display Text");
        text.guiText.text = "Game";
	}
	
	// Update is called once per frame
	void Update () 
    {
        controler_manager();
	}

    void controler_manager()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.P))
        {
            GameObject text = GameObject.Find("Display Text");
            if(text.guiText.text != "Pause")
            {
                pause(text);
            }
            else
            {
                unpause(text);
            }
        }
    }

    void pause(GameObject text)
    {
        text.guiText.text = "Pause";
    }

    void unpause(GameObject text)
    {
        text.guiText.text = "Game";
    }
}
