using UnityEngine;
using System.Collections;

namespace Programme
{
    public class main : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            controler_manager();
            zoom_camera();
        }

        void controler_manager()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (Time.timeScale == 0)
                {
                    unpause();
                }
                else
                {
                    pause();
                }

            }
        }

        void zoom_camera()
        {
            int movespeed = 20;
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.transform.position = new Vector3(-1532, 1465, -1632);
            }
            else if (Input.GetAxis("Mouse ScrollWheel") > 0) //ZOOM AVANT
            {
                if (this.transform.position.x <= -50 && this.transform.position.y >= 50 && this.transform.position.z <= -200)
                {
                    this.transform.position = new Vector3(this.transform.position.x + movespeed, this.transform.position.y - 17, this.transform.position.z + movespeed);
                }
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0) //ZOOM ARRIERE
            {
                if (this.transform.position.x >= -2012 && this.transform.position.y <= 1945 && this.transform.position.z >= -2112)
                {
                    this.transform.position = new Vector3(this.transform.position.x - movespeed, this.transform.position.y + 17, this.transform.position.z - movespeed);
                }
            }
        }

        void pause()
        {
            GameObject button_pause = GameObject.Find("Button_Pause");
            GameObject button_pauseFR = GameObject.Find("Button_PauseFR");
            GameObject button_unpause = GameObject.Find("Button_unPause");
            GameObject button_unpauseFR = GameObject.Find("Button_unPauseFR");
            GameObject button_Menu = GameObject.Find("Button_Menu");
            GameObject button_New_Game = GameObject.Find("Button_New_Game");
            GameObject button_New_GameFR = GameObject.Find("Button_New_GameFR");
            GameObject button_Option = GameObject.Find("Button_Option");
            GameObject button_OptionFR = GameObject.Find("Button_OptionFR");
            GameObject button_Exit = GameObject.Find("Button_Exit");
            GameObject button_ExitFR = GameObject.Find("Button_ExitFR");
            Time.timeScale = 0;
            if (button_pauseFR.transform.position.x == 7166) //LE JEU EST EN ANGLAIS
            {
                button_unpause.transform.position = new Vector3(500, 670, 0);
                button_New_Game.transform.position = new Vector3(500, 500, 0);
                button_Exit.transform.position = new Vector3(500, 330, 0);
                button_pause.transform.position = new Vector3(7166, 6436, 0);
                button_Option.transform.position = new Vector3(500, 415, 0);
            }
            else //LE JEU EST EN FR
            {
                button_unpauseFR.transform.position = new Vector3(500, 670, 0);
                button_New_GameFR.transform.position = new Vector3(500, 500, 0);
                button_ExitFR.transform.position = new Vector3(500, 330, 0);
                button_pauseFR.transform.position = new Vector3(7166, 6436, 0);
                button_OptionFR.transform.position = new Vector3(500, 415, 0);
            }

            button_Menu.transform.position = new Vector3(500, 585, 0);
        }

        void unpause()
        {
            GameObject button_pause = GameObject.Find("Button_Pause");
            GameObject button_pauseFR = GameObject.Find("Button_PauseFR");
            GameObject button_unpause = GameObject.Find("Button_unPause");
            GameObject button_unpauseFR = GameObject.Find("Button_unPauseFR");
            GameObject button_Menu = GameObject.Find("Button_Menu");
            GameObject button_New_Game = GameObject.Find("Button_New_Game");
            GameObject button_New_GameFR = GameObject.Find("Button_New_GameFR");
            GameObject button_Option = GameObject.Find("Button_Option");
            GameObject button_OptionFR = GameObject.Find("Button_OptionFR");
            GameObject button_English = GameObject.Find("Button_English");
            GameObject button_French = GameObject.Find("Button_French");
            GameObject button_son = GameObject.Find("Button_son");
            GameObject button_couper = GameObject.Find("Button_muet");
            GameObject button_sound = GameObject.Find("Button_sound");
            GameObject button_mute = GameObject.Find("Button_mute");
            GameObject button_Exit = GameObject.Find("Button_Exit");
            GameObject button_ExitFR = GameObject.Find("Button_ExitFR");
            Time.timeScale = 1;
            if (button_unpauseFR.transform.position.x == 7166) //LE JEU EST EN ANGLAIS
            {
                button_pause.transform.position = new Vector3(80, 720, 0);
                button_unpause.transform.position = new Vector3(7166, 6436, 0);
                button_New_Game.transform.position = new Vector3(7166, 6436, 0);
                button_Exit.transform.position = new Vector3(7166, 6436, 0);
                button_Option.transform.position = new Vector3(7166, 6436, 0);
                button_sound.transform.position = new Vector3(7166, 6436, 0);
                button_mute.transform.position = new Vector3(7166, 6436, 0);
            }
            else //LE JEU EST EN FR
            {
                button_pauseFR.transform.position = new Vector3(80, 720, 0);
                button_unpauseFR.transform.position = new Vector3(7166, 6436, 0);
                button_New_GameFR.transform.position = new Vector3(7166, 6436, 0);
                button_ExitFR.transform.position = new Vector3(7166, 6436, 0);
                button_OptionFR.transform.position = new Vector3(7166, 6436, 0);
                button_son.transform.position = new Vector3(7166, 6436, 0);
                button_couper.transform.position = new Vector3(7166, 6436, 0);
            }
            button_Menu.transform.position = new Vector3(7166, 6436, 0);
            button_English.transform.position = new Vector3(7166, 6436, 0);
            button_French.transform.position = new Vector3(7166, 6436, 0);
        }
    }
}

