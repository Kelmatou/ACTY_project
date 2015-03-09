using UnityEngine;
using System.Collections;

public class button_managment : MonoBehaviour 
{	
    public void move_out_screen()
    {
        this.transform.position = new Vector3(7166, 6436, 0);
    }

    public void move_in_screen()
    {
        this.transform.position = new Vector3(-7166, -6436, 0);
    }
}
