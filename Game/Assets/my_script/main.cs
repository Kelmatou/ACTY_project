using UnityEngine;
using System.Collections;

namespace Programme
{
    public class main : MonoBehaviour
    {
        int team1_zinc;
        int team1_roche;
        int team1_uranium;
        int team1_stock_capacity;
        int team1_unit_nbr;

        int team2_zinc;
        int team2_roche;
        int team2_uranium;
        int team2_stock_capacity;
        int team2_unit_nbr;

        // Use this for initialization
        void Start()
        {
            team1_zinc = 50;
            team1_roche = 100;
            team1_uranium = 30;
            team1_stock_capacity = 120;
            team1_unit_nbr = 1;

            team2_zinc = 50;
            team2_roche = 100;
            team2_uranium = 30;
            team2_stock_capacity = 120;
            team2_unit_nbr = 1;
            get_zinc(1);
        }

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
            if(Input.GetKeyDown(KeyCode.R))
            {
                this.transform.position = new Vector3(-1532, 1465, -1632);
            }
            else if(Input.GetAxis("Mouse ScrollWheel") > 0) //ZOOM AVANT
            {
                //if(this.transform.position.x <= -512 && this.transform.position.y >= 445 && this .transform.position.z <= -612)
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
            GameObject button_Exit = GameObject.Find("Button_Exit");
            GameObject button_ExitFR = GameObject.Find("Button_ExitFR");
            Time.timeScale = 0;
            if (button_pauseFR.transform.position.x == 7166) //LE JEU EST EN ANGLAIS
            {
                button_unpause.transform.position = new Vector3(500, 670, 0);
                button_New_Game.transform.position = new Vector3(500, 500, 0);
                button_Exit.transform.position = new Vector3(500, 330, 0);
                button_pause.transform.position = new Vector3(7166, 6436, 0);
            }
            else //LE JEU EST EN FR
            {
                button_unpauseFR.transform.position = new Vector3(500, 670, 0);
                button_New_GameFR.transform.position = new Vector3(500, 500, 0);
                button_ExitFR.transform.position = new Vector3(500, 330, 0);
                button_pauseFR.transform.position = new Vector3(7166, 6436, 0);
            }
            
            button_Menu.transform.position = new Vector3(500, 585, 0);
            button_Option.transform.position = new Vector3(500, 415, 0);
            
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
            GameObject button_Exit = GameObject.Find("Button_Exit");
            GameObject button_ExitFR = GameObject.Find("Button_ExitFR");
            Time.timeScale = 1;
            if (button_unpauseFR.transform.position.x == 7166) //LE JEU EST EN ANGLAIS
            {
                button_pause.transform.position = new Vector3(80, 720, 0);
                button_unpause.transform.position = new Vector3(7166, 6436, 0);
                button_New_Game.transform.position = new Vector3(7166, 6436, 0);
                button_Exit.transform.position = new Vector3(7166, 6436, 0);
            }
            else //LE JEU EST EN FR
            {
                button_pauseFR.transform.position = new Vector3(80, 720, 0);
                button_unpauseFR.transform.position = new Vector3(7166, 6436, 0);
                button_New_GameFR.transform.position = new Vector3(7166, 6436, 0);
                button_ExitFR.transform.position = new Vector3(7166, 6436, 0);
            }
            button_Menu.transform.position = new Vector3(7166, 6436, 0);
            button_Option.transform.position = new Vector3(7166, 6436, 0);
        }

        public int get_zinc(int team = 2)
        {
            if(team == 1)
            {
                return(team1_zinc);
            }
            else
            {
                return(team2_zinc);
            }
        }

        public void add_zinc(int nbr, int team = 2)
        {
            if (team == 1)
            {
                team1_zinc = team1_zinc + nbr;
            }
            else
            {
                team2_zinc = team2_zinc + nbr;
            }
        }
    }
}

