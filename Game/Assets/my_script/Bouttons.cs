using UnityEngine;
using System.Collections;

public class Bouttons : MonoBehaviour 
{

    public void StartGame()
    {
        Application.LoadLevel("map_1_selection");
    }

    public void launch_map_1()
    {
        Application.LoadLevel("map_1");
    }

    public void launch_map_2()
    {
        Application.LoadLevel("map_2");
    }

    public void launch_map_3()
    {
        Application.LoadLevel("map_3");
    }

    public void launch_menu()
    {
        if (this.name == "Button_Menu")
        {
            Time.timeScale = 1;
        }
        Application.LoadLevel("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
