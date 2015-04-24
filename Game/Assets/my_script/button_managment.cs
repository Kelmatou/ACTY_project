using UnityEngine;
using System.Collections;

public class button_managment : MonoBehaviour 
{

    void Start()
    {
        if(this.name == "Button_Pause")
        {
            if(Time.timeScale == 1)
            {
                this.transform.position = new Vector3(80, 720, 0);
            }
            else
            {
                this.transform.position = new Vector3(7166, 6436, 0);
            }
        }
        else if (this.name == "Button_unPause")
        {
            if (Time.timeScale == 0)
            {
                this.transform.position = new Vector3(80, 720, 0);
            }
            else
            {
                this.transform.position = new Vector3(7166, 6436, 0);
            }
        }
        else if (this.name == "Button_Menu")
        {
            if (Time.timeScale == 0)
            {
                this.transform.position = new Vector3(500, 670, 0);
            }
            else
            {
                this.transform.position = new Vector3(7166, 6436, 0);
            }
        }
        else
        {
            if(Time.timeScale == 1)
            {
                creat_game_inteface();
            }
            else
            {
                move_out_screen();
            }
        }
    }

    public void move_out_screen()
    {
        this.transform.position = new Vector3(7166, 6436, 0);
        if(this.name == "Button_Pause")
        {
            Time.timeScale = 0;
        }
    }

    public void move_in_screen()
    {
        this.transform.position = new Vector3(80, 720, 0);
        if (this.name == "Button_Pause")
        {
            Time.timeScale = 1;
        }
    }

    public void creat_pause_menu()
    {
        if (this.name == "Button_Menu")
        {
            this.transform.position = new Vector3(500, 670, 0);
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
                this.transform.position = new Vector3(92, 42, 0);
                break;
            case ("Button_Caserne"):
                this.transform.position = new Vector3(142, 42, 0);
                break;
            case ("Button_Wall"):
                this.transform.position = new Vector3(192, 42, 0);
                break;
            case ("Button_Temple"):
                this.transform.position = new Vector3(242, 42, 0);
                break;
            case ("Button_Lab"):
                this.transform.position = new Vector3(292, 42, 0);
                break;
            case ("Button_Bank"):
                this.transform.position = new Vector3(342, 42, 0);
                break;
            case ("Button_Mine"):
                this.transform.position = new Vector3(392, 42, 0);
                break;
            case ("Button_Carrier"):
                this.transform.position = new Vector3(442, 42, 0);
                break;
            case ("Button_Center"):
                this.transform.position = new Vector3(492, 42, 0);
                break;
            default:
                Debug.Log("bouton inconnu");
                break;
        }
    }
}
