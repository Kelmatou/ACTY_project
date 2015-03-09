using UnityEngine;
using System.Collections;

public class Pause_mode : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        

	}

    public void pause()
    {
        Time.timeScale = 0;
    }

    public void unpause()
    {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if(GUI.Button(new Rect(-490, 240, 160, 30), "RESUME"))
        {
            print("unpause"); 
            unpause();
        }
        else if(GUI.Button(new Rect(-490, 180, 160, 30), "PAUSE"))
        {
            print("pause");
            pause();
        }
     }
}
