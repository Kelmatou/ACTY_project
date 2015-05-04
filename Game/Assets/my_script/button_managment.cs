using UnityEngine;
using System.Collections;

public class button_managment : MonoBehaviour 
{
    bool default_language;

    void Start()
    {
        default_language = true;
        if(this.name == "Button_Pause")
        {
            this.transform.position = new Vector3(80, 720, 0);
        }
        else if (this.name == "Button_PauseFR" || this.name == "Button_unPause" || this.name == "Button_unPauseFR" || this.name == "Button_Menu" || this.name == "Button_New_Game" || this.name == "Button_New_GameFR" || this.name == "Button_Option" || this.name == "Button_Exit" || this.name == "Button_ExitFR" || this.name == "Button_English" || this.name == "Button_French")
        {
            move_out_screen();
        }
        else
        {
            creat_game_inteface();
        }
    }

    public void move_out_screen()
    {
        this.transform.position = new Vector3(7166, 6436, 0);
        if(this.name == "Button_Pause" && default_language)
        {
            Time.timeScale = 0;
        }
        if (this.name == "Button_PauseFR" && !default_language)
        {
            Time.timeScale = 0;
        }
    }

    public void move_in_screen()
    {
        this.transform.position = new Vector3(80, 720, 0);
        if (this.name == "Button_Pause" || this.name == "Button_PauseFR")
        {
            Time.timeScale = 1;
        }
    }

    public void creat_pause_menu()
    {
        if (this.name == "Button_unPause" || this.name == "Button_unPauseFR")
        {
            this.transform.position = new Vector3(500, 670, 0);
        }
        else if (this.name == "Button_Menu")
        {
            this.transform.position = new Vector3(500, 585, 0);
        }
        else if (this.name == "Button_New_Game" || this.name == "Button_New_GameFR")
        {
            this.transform.position = new Vector3(500, 500, 0);
        }
        else if (this.name == "Button_Option")
        {
            this.transform.position = new Vector3(500, 415, 0);
        }
        else if (this.name == "Button_Exit" || this.name == "Button_ExitFR")
        {
            this.transform.position = new Vector3(500, 330, 0);
        }
        else if(this.name == "Button_French")
        {
            this.transform.position = new Vector3(250, 415, 0);
        }
        else if(this.name == "Button_English")
        {
            this.transform.position = new Vector3(750, 415, 0);
        }
    }

    public void creat_game_inteface()
    {
        switch(this.name)
        {
            case("Button_Donjon"):
                this.transform.position = new Vector3(42, 42, 0);
                break;
            case ("Button_Tower"):
                this.transform.position = new Vector3(102, 42, 0);
                break;
            case ("Button_Caserne"):
                this.transform.position = new Vector3(162, 42, 0);
                break;
            case ("Button_Wall"):
                this.transform.position = new Vector3(222, 42, 0);
                break;
            case ("Button_Temple"):
                this.transform.position = new Vector3(282, 42, 0);
                break;
            case ("Button_Lab"):
                this.transform.position = new Vector3(342, 42, 0);
                break;
            case ("Button_Bank"):
                this.transform.position = new Vector3(402, 42, 0);
                break;
            case ("Button_Mine"):
                this.transform.position = new Vector3(462, 42, 0);
                break;
            case ("Button_Carrier"):
                this.transform.position = new Vector3(522, 42, 0);
                break;
            case ("Button_Center"):
                this.transform.position = new Vector3(582, 42, 0);
                break;
            default:
                Debug.Log("bouton inconnu");
                break;
        }
    }

    public void change_language()
    {
        default_language = this.name == "Button_English";
    }
}
