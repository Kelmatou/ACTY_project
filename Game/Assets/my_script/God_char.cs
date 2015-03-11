using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    float movespeed;
    float auto_path_x;
    float auto_path_z;
    string direction;

    // Use this for initialization
    void Start()
    {
        direction = "N";
        gameObject.name = "Kelmatou";
        movespeed = 1f;
        auto_path_x = -1;
        auto_path_z = -1;
        gameObject.transform.position = new Vector3(42, 1.5f, 42);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            move(movespeed);
            if(auto_path_x != -1 && auto_path_z != -1)
            {
                auto_path();
            }
            if(Input.GetMouseButtonDown(0))
            {
                creat_building(Input.mousePosition.x, Input.mousePosition.z);
            }
        } 
    }
    
    void auto_path()
    {
        if (auto_path_x > this.transform.position.x && auto_path_z > this.transform.position.z)
        {
            direction = "NW";
            this.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed));
        }
        else if (auto_path_x > this.transform.position.x && auto_path_z < this.transform.position.z)
        {
            direction = "NE";
            this.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed));
        }
        else if (auto_path_x < this.transform.position.x && auto_path_z > this.transform.position.z)
        {
            direction = "SW";
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed));
        }
        else if (auto_path_x < this.transform.position.x && auto_path_z < this.transform.position.z)
        {
            direction = "SE";
            this.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed));
        }
        else if (auto_path_x > this.transform.position.x)
        {
            direction = "N";
            this.transform.Translate(new Vector3(1 * movespeed, 0, 0));
        }
        else if (auto_path_x < this.transform.position.x)
        {
            direction = "S";
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (auto_path_z > this.transform.position.z)
        {
            direction = "W";
            this.transform.Translate(new Vector3(0, 0, 1 * movespeed));
        }
        else if (auto_path_z < this.transform.position.z)
        {
            direction = "E";
            this.transform.Translate(new Vector3(0, 0, -1 * movespeed));
        }
    }

    void move(float movespeed)
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            direction = "N";
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                direction = "NW";
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed)); //go up and left
                    reset_auto_path();
                }
            }
            else if(Input.GetKey(KeyCode.RightArrow))
            {
                direction = "NE";
                if (gameObject.transform.position.z > 2 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed)); //go up and right
                    reset_auto_path();
                }
            }
            else if (gameObject.transform.position.x < 400)
            {
                gameObject.transform.Translate(new Vector3(1 * movespeed, 0, 0)); //go up
                reset_auto_path();
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = "S";
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction = "SW";
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x > 2)
                {
                    gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed)); //go down and left
                    reset_auto_path();
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                direction = "SE";
                if (gameObject.transform.position.z > 2 && gameObject.transform.position.x > 2)
                {
                    gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed)); //go down and right
                    reset_auto_path();
                }
            }
            else if(gameObject.transform.position.x > 2)
            {
                gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, 0)); //go down
                reset_auto_path();
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = "W";
            if (gameObject.transform.position.z < 400)
            {
                gameObject.transform.Translate(new Vector3(0, 0, 1 * movespeed)); //go left
                reset_auto_path();
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = "E";
            if (gameObject.transform.position.z > 2)
            {
                gameObject.transform.Translate(new Vector3(0, 0, -1 * movespeed)); //go right
                reset_auto_path();
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            auto_path_x = Input.mousePosition.x;
            auto_path_z = Input.mousePosition.y;

            if(auto_path_x > 400)
            {
                auto_path_x = 400;
            }
            if(auto_path_x < 0)
            {
                auto_path_x = 0;
            }
            if(auto_path_z > 400)
            {
                auto_path_z = 400;
            }
            if(auto_path_z < 0)
            {
                auto_path_z = 0;
            }
        }
    }

    void creat_building(float mouse_x, float mouse_z)
    {
        switch(direction)
        {
            case("N"):
                if(this.transform.position.x + 10 <= 400 && this.transform.position.z <= 395 && this.transform.position.z >= 5)
                {
                    build((int)this.transform.position.x + 5, (int)this.transform.position.z);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + 5) + ", z = " + this.transform.position.z + " en direction " + direction);
                }
                break;
            case ("NW"):
                if (this.transform.position.x + 10 <= 400 && this.transform.position.z + 10 <= 400)
                {
                    build((int)this.transform.position.x + 5, (int)this.transform.position.z + 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + 5) + ", z = " + (this.transform.position.z + 5) + " en direction " + direction);
                }
                break;
            case ("NE"):
                if (this.transform.position.x + 10 <= 400 && this.transform.position.z - 10 >= 0)
                {
                    build((int)this.transform.position.x + 5, (int)this.transform.position.z - 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + 5) + ", z = " + (this.transform.position.z - 5) + " en direction " + direction);
                }
                break;
            case ("S"):
                if (this.transform.position.x - 10 >= 0 && this.transform.position.z <= 395 && this.transform.position.z >= 5)
                {
                    build((int)this.transform.position.x - 5, (int)this.transform.position.z);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - 5) + ", z = " + this.transform.position.z + " en direction " + direction);
                }
                break;
            case ("SW"):
                if (this.transform.position.x - 10 >= 0 && this.transform.position.z + 10 <= 400)
                {
                    build((int)this.transform.position.x - 5, (int)this.transform.position.z + 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - 5) + ", z = " + (this.transform.position.z + 5) + " en direction " + direction);
                }
                break;
            case ("SE"):
                if (this.transform.position.x - 10 >= 0 && this.transform.position.z - 10 >= 0)
                {
                    build((int)this.transform.position.x - 5, (int)this.transform.position.z - 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - 5) + ", z = " + (this.transform.position.z - 5) + " en direction " + direction);
                }
                break;
            case ("W"):
                if (this.transform.position.z + 10 <= 400 && this.transform.position.x <= 395 && this.transform.position.x >= 5)
                {
                    build((int)this.transform.position.x, (int)this.transform.position.z + 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + this.transform.position.x + ", z = " + (this.transform.position.z + 5) + " en direction " + direction);
                }
                break;
            case ("E"):
                if (this.transform.position.z - 10 >= 0 && this.transform.position.x <= 395 && this.transform.position.x >= 5)
                {
                    build((int)this.transform.position.x, (int)this.transform.position.z - 5);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + this.transform.position.x + ", z = " + (this.transform.position.z - 5) + " en direction " + direction);
                }
                break;
            default:
                Debug.Log("Direction inconnue");
                break;
        }
    }

    void build(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent("BoxCollider");
        cube.AddComponent("collision");
        cube.name = "house";
        cube.transform.transform.localScale = new Vector3(10, 10, 10);
        cube.transform.position = new Vector3(x, 5, z);
    }

    void reset_auto_path()
    {
        auto_path_x = -1;
        auto_path_z = -1;
    }

}
