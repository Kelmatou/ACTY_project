using UnityEngine;
using System.Collections;

public class button_managment : MonoBehaviour 
{	

    void Start()
    {
        if(this.name == "Button_Pause")
        {
            this.transform.position = new Vector3(94.5f, 1024.5f, 0);
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
        //this.transform.position = new Vector3(94.5f, 474.5f, 0); ne fonctionne pas apres compilation
        //this.transform.position = new Vector3(94.5f, 704.5f, 0); //1024x768
        this.transform.position = new Vector3(94.5f, 1024.5f, 0); // 1920x1080
        if (this.name == "Button_Pause")
        {
            Time.timeScale = 1;
        }
    }
}
