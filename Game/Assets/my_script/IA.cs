using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour 
{
    private int movespeed; //should creat an object

	// Use this for initialization
	void Start () 
    {
        gameObject.name = "Dark Vador";
        movespeed = 1;
        gameObject.transform.position = new Vector3(358, 0, 358);
	}
	
	// Update is called once per frame
	void Update () 
    {
        GameObject text = GameObject.Find("Display Text");
        if (text.guiText.text != "Pause")
        {
            hunt(GameObject.Find("Kelmatou"), movespeed);
        }
	}

    void hunt(GameObject target, int movespeed)
    {
        if (target.transform.position.x > this.transform.position.x && target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed));
        }
        else if (target.transform.position.x > this.transform.position.x && target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed));
        }
        else if (target.transform.position.x < this.transform.position.x && target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed));
        }
        else if (target.transform.position.x < this.transform.position.x && target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed));
        }
        else if (target.transform.position.x > this.transform.position.x)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x < this.transform.position.x)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, 1 * movespeed));
        }
        else if (target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, -1 * movespeed));
        }
    }
}
