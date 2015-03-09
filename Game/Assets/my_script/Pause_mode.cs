using UnityEngine;
using System.Collections;

public class Pause_mode : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
       GUI.Button(new Rect(-500, 200, 250, 50), "RESUME");
       Time.timeScale = 0;
       Debug.Log("Bouton crée");
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
            Debug.Log("unpause"); 
            unpause();
        }
        else if(GUI.Button(new Rect(-490, 180, 160, 30), "PAUSE"))
        {
            Debug.Log("pause");
            pause();
        }
     }
}
