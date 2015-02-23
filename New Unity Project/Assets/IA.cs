using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        gameObject.name = "Dark Vador";
        gameObject.transform.position = new Vector3(358, 0, 358);
	}
	
	// Update is called once per frame
	void Update () 
    {
        hunt(GameObject.Find("Kelmatou"));
	}

    void hunt(GameObject target)
    {
        if (target.transform.position.x > this.transform.position.x && target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(1, 0, 1));
        }
        else if (target.transform.position.x > this.transform.position.x && target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(1, 0, -1));
        }
        else if (target.transform.position.x < this.transform.position.x && target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1, 0, 1));
        }
        else if (target.transform.position.x < this.transform.position.x && target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1, 0, -1));
        }
        else if (target.transform.position.x > this.transform.position.x)
        {
            this.transform.Translate(new Vector3(1, 0, 0));
        }
        else if (target.transform.position.x < this.transform.position.x)
        {
            this.transform.Translate(new Vector3(-1, 0, 0));
        }
        else if (target.transform.position.z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, 1));
        }
        else if (target.transform.position.z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, -1));
        }
    }
}
