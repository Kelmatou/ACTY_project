using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour 
{
    float movespeed; //should creat an object
    string direction;

	// Use this for initialization
	void Start () 
    {
<<<<<<< HEAD
        if(this.name != "Player(Clone)" && this.name != "FERDINAN_player" && this.name != "Player")
        {
            gameObject.name = "Ennemy";
            direction = "N";
            movespeed = 0.5f;
            gameObject.transform.position = new Vector3(358, 5, 358);
        }
        else
        {
            movespeed = 1f;
        }
=======
        direction = "N";
        gameObject.name = "Dark Vador";
        movespeed = 0.5f;
        gameObject.transform.position = new Vector3(358, 5, 358);
>>>>>>> f946c0f40335e321420f8e46944aa0357dcfd393
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Time.timeScale != 0)
        {
<<<<<<< HEAD
            if(this.name == "Ennemy")
            {
                hunt(GameObject.Find("Player"), movespeed);
            }
            else
            {
                hunt(GameObject.Find("Ennemy"), movespeed);
            }
=======
            hunt(GameObject.Find("Kelmatou"), movespeed);
>>>>>>> f946c0f40335e321420f8e46944aa0357dcfd393
        }
	}

    void apply_rotation(string old_direction)
    {
        switch (old_direction)
        {
            case ("N"):
                switch (direction)
                {
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                }
                break;
            case ("NE"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                }
                break;
            case ("NW"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                }
                break;
            case ("S"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                }
                break;
            case ("SE"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                }
                break;
            case ("SW"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                }
                break;
            case ("E"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("W"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                }
                break;
            case ("W"):
                switch (direction)
                {
                    case ("N"):
                        this.transform.Rotate(new Vector3(0, 90, 0));
                        break;
                    case ("NE"):
                        this.transform.Rotate(new Vector3(0, 135, 0));
                        break;
                    case ("NW"):
                        this.transform.Rotate(new Vector3(0, 45, 0));
                        break;
                    case ("S"):
                        this.transform.Rotate(new Vector3(0, 270, 0));
                        break;
                    case ("SE"):
                        this.transform.Rotate(new Vector3(0, 225, 0));
                        break;
                    case ("SW"):
                        this.transform.Rotate(new Vector3(0, 315, 0));
                        break;
                    case ("E"):
                        this.transform.Rotate(new Vector3(0, 180, 0));
                        break;
                }
                break;
        }
    }

    void hunt(GameObject target, float movespeed)
    {
        string old_direction = direction;

<<<<<<< HEAD
        if(target != null)
        {
            if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
            {
                direction = "SE";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
            {
                direction = "SW";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
            {
                direction = "NE";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
            {
                direction = "NW";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed)
            {
                direction = "S";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed)
            {
                direction = "N";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
            {
                direction = "E";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
            else if (target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
            {
                direction = "W";
                apply_rotation(old_direction);
                this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
            }
        }
=======
        if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
        {
            direction = "SE";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
        {
            direction = "SW";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z - 2 > this.transform.position.z + 1 * movespeed)
        {
            direction = "NE";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x + 2 < this.transform.position.x - 1 * movespeed && target.transform.position.z + 2 < this.transform.position.z - 1 * movespeed)
        {
            direction = "NW";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x - 2 > this.transform.position.x + 1 * movespeed)
        {
            direction = "S";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.x  + 2 < this.transform.position.x - 1 * movespeed)
        {
            direction = "N";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.z - 2> this.transform.position.z + 1 * movespeed)
        {
            direction = "E";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (target.transform.position.z + 2< this.transform.position.z - 1 * movespeed)
        {
            direction = "W";
            apply_rotation(old_direction);
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        Debug.Log(direction);
>>>>>>> f946c0f40335e321420f8e46944aa0357dcfd393
    }
}
