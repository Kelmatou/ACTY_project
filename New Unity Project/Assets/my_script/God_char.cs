using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    int movespeed;
    float auto_path_x;
    float auto_path_z;

    // Use this for initialization
    void Start()
    {
        gameObject.name = "Kelmatou";
        movespeed = 2;
        auto_path_x = -1;
        auto_path_z = -1;
        gameObject.transform.position = new Vector3(42, 0, 42);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject text = GameObject.Find("Display Text");
        if(text.guiText.text != "Pause")
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
            this.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed));
        }
        else if (auto_path_x > this.transform.position.x && auto_path_z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed));
        }
        else if (auto_path_x < this.transform.position.x && auto_path_z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed));
        }
        else if (auto_path_x < this.transform.position.x && auto_path_z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed));
        }
        else if (auto_path_x > this.transform.position.x)
        {
            this.transform.Translate(new Vector3(1 * movespeed, 0, 0));
        }
        else if (auto_path_x < this.transform.position.x)
        {
            this.transform.Translate(new Vector3(-1 * movespeed, 0, 0));
        }
        else if (auto_path_z > this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, 1 * movespeed));
        }
        else if (auto_path_z < this.transform.position.z)
        {
            this.transform.Translate(new Vector3(0, 0, -1 * movespeed));
        }
    }

    void move(int movespeed)
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1 * movespeed, 0, 1 * movespeed)); //go up and left
                    reset_auto_path();
                }
            }
            else if(Input.GetKey(KeyCode.RightArrow))
            {
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
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x > 2)
                {
                    gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed)); //go down and left
                    reset_auto_path();
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
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
            if (gameObject.transform.position.z < 400)
            {
                gameObject.transform.Translate(new Vector3(0, 0, 1 * movespeed)); //go left
                reset_auto_path();
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.z > 2)
            {
                gameObject.transform.Translate(new Vector3(0, 0, -1 * movespeed)); //go right
                reset_auto_path();
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            auto_path_x = Input.mousePosition.x;
            auto_path_z = Input.mousePosition.z;
        }
    }

    void creat_building(float mouse_x, float mouse_z)
    {
        int pos_x = 0;
        int pos_z = 0;

        while((pos_x == this.transform.position.x && pos_z == this.transform.position.z) || pos_x > 395 || pos_x < 15 || pos_z > 395 || pos_z < 5)
        {
            pos_x = (int)(this.transform.position.x + Random.Range(-1, 2) * 10);
            pos_z = (int)(this.transform.position.z + Random.Range(-1, 2) * 10);
        }
        build(pos_x,pos_z);
    }

    void build(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "house";
        cube.transform.transform.localScale = new Vector3(10, 10, 10);
        cube.transform.position = new Vector3(x, 0, z);
    }

    void reset_auto_path()
    {
        auto_path_x = -1;
        auto_path_z = -1;
    }

}
