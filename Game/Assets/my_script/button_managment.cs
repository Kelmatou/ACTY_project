using UnityEngine;
using System.Collections;

public class button_managment : MonoBehaviour 
{

    void Start()
    {
        if (this.name == "Button_Pause" && Time.timeScale == 1)
        {
            this.transform.position = new Vector3(80, 720, 0);
        }
        else if (this.name == "Button_Pause")
        {
            this.transform.position = new Vector3(7166, 6436, 0);
        }

        if (this.name == "Button_unPause" && Time.timeScale == 0)
        {
            this.transform.position = new Vector3(80, 720, 0);
        }
        else if (this.name == "Button_unPause")
        {
            this.transform.position = new Vector3(7166, 6436, 0);
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
}
