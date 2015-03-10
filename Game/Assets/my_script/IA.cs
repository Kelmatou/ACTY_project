using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour 
{
    private float movespeed; //should creat an object

	// Use this for initialization
	void Start () 
    {
        gameObject.name = "Dark Vador";
        movespeed = 0.5f;
        gameObject.transform.position = new Vector3(358, 1.5f, 358);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Time.timeScale != 0)
        {
            hunt(GameObject.Find("Kelmatou"), movespeed);
        }
	}

    void hunt(GameObject target, float movespeed)
    {
        if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed));
        }
        else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed));
        }
        else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed));
        }
        else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed));
        }
        else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x  + 2 < this.transform.position.x - 1 * movespeed)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.z - 2> this.transform.position.z + 1 * movespeed)
        {
            this.transform.Translate(new Vector3(0, 0, 1 * movespeed));
        }
        else if (target.transform.position.z + 2< this.transform.position.z - 1 * movespeed)
        {
            this.transform.Translate(new Vector3(0, 0, -1 * movespeed));
        }
    }
}
