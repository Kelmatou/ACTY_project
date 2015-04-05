using UnityEngine;
using System.Collections;

public class change_map : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
    {
	    load_map();
	}

    void load_map()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && this.name != "Map1")
        {
            Application.LoadLevel("map_1");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && this.name != "Map2")
        {
            Application.LoadLevel("map_2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && this.name != "Map3")
        {
            Application.LoadLevel("map_3");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
