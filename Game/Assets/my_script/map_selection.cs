using UnityEngine;
using System.Collections;

public class map_selection : MonoBehaviour 
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            launch_next_map_selection();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            launch_previous_map_selection();
        }
        else if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            launch_current_map();
        }
    }

    void launch_current_map()
    {
        switch(this.name)
        {
            case("Map1_selection"):
                launch_map1();
                break;
            case ("Map2_selection"):
                launch_map2();
                break;
            case ("Map3_selection"):
                launch_map3();
                break;
        }
    }

	void launch_next_map_selection()
    {
        if (this.name == "Map1_selection")
        {
            launch_map2_selection();
        }
        if (this.name == "Map2_selection")
        {
            launch_map3_selection();
        }
        if (this.name == "Map3_selection")
        {
            launch_map1_selection();
        }
    }

    void launch_previous_map_selection()
    {
        if (this.name == "Map1_selection")
        {
            launch_map3_selection();
        }
        if (this.name == "Map2_selection")
        {
            launch_map1_selection();
        }
        if (this.name == "Map3_selection")
        {
            launch_map2_selection();
        }
    }

    public void launch_map1_selection()
    {
        Application.LoadLevel("map_1_selection");
    }

    public void launch_map2_selection()
    {
        Application.LoadLevel("map_2_selection");
    }

    public void launch_map3_selection()
    {
        Application.LoadLevel("map_3_selection");
    }

    public void launch_map1()
    {
        Time.timeScale = 1;
        Application.LoadLevel("map_1");
    }

    public void launch_map2()
    {
        Time.timeScale = 1;
        Application.LoadLevel("map_2");
    }

    public void launch_map3()
    {
        Time.timeScale = 1;
        Application.LoadLevel("map_3");
    }

    public void return_to_menu()
    {
        Time.timeScale = 1;
        Application.LoadLevel("MenuEN");
    }
}
