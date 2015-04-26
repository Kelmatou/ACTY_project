using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    float movespeed;
    double auto_path_x;
    double auto_path_z;
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
        if (Time.timeScale != 0)
        {
            move(movespeed);
            if (auto_path_x != -1 && auto_path_z != -1)
            {
                auto_path();
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
            auto_path_x = System.Math.Round(Input.mousePosition.x, 0);
            auto_path_z = System.Math.Round(Input.mousePosition.y, 0);
            Debug.Log("pos x: " + auto_path_x + " - pos y: " + auto_path_z);

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

    void reset_auto_path()
    {
        auto_path_x = -1;
        auto_path_z = -1;
    }

    bool can_be_build(int size_x, int size_z)
    {
        switch (direction)
        {
            case ("N"):
                if (this.transform.position.x + size_x <= 400 && this.transform.position.z <= 400 - size_z / 2 && this.transform.position.z >= size_z / 2)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + size_x/2) + ", z = " + this.transform.position.z + " en direction " + direction);
                }
                break;
            case ("NW"):
                if (this.transform.position.x + size_x <= 400 && this.transform.position.z + size_z <= 400)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + size_x / 2) + ", z = " + (this.transform.position.z + size_z / 2) + " en direction " + direction);
                }
                break;
            case ("NE"):
                if (this.transform.position.x + size_x <= 400 && this.transform.position.z - size_z >= 0)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x + size_x / 2) + ", z = " + (this.transform.position.z - size_z / 2) + " en direction " + direction);
                }
                break;
            case ("S"):
                if (this.transform.position.x - size_x >= 0 && this.transform.position.z <= 400 - size_z / 2 && this.transform.position.z >= size_z / 2)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - size_x / 2) + ", z = " + this.transform.position.z + " en direction " + direction);
                }
                break;
            case ("SW"):
                if (this.transform.position.x - size_x >= 0 && this.transform.position.z + size_z <= 400)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - size_x / 2) + ", z = " + (this.transform.position.z + size_z / 2) + " en direction " + direction);
                }
                break;
            case ("SE"):
                if (this.transform.position.x - size_x >= 0 && this.transform.position.z - size_z >= 0)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + (this.transform.position.x - size_x / 2) + ", z = " + (this.transform.position.z - size_z / 2) + " en direction " + direction);
                }
                break;
            case ("W"):
                if (this.transform.position.z + size_z <= 400 && this.transform.position.x <= 400 - size_x / 2 && this.transform.position.x >= size_x / 2)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + this.transform.position.x + ", z = " + (this.transform.position.z + size_z / 2) + " en direction " + direction);
                }
                break;
            case ("E"):
                if (this.transform.position.z - size_z >= 0 && this.transform.position.x <= 400 - size_x / 2 && this.transform.position.x >= size_x / 2)
                {
                    return (true);
                }
                else
                {
                    Debug.Log("Pas assez de place pour construire au point x = " + this.transform.position.x + ", z = " + (this.transform.position.z - size_z / 2) + " en direction " + direction);
                }
                break;
            default:
                Debug.Log("Direction inconnue");
                break;
        }
        return (false);
    }

    public void build_building(string tag)
    {
        if(Time.timeScale == 1)
        {
            switch (tag)
            {
                case ("Donjon"):
                    if (can_be_build(5, 5))
                    {
                        build_donjon((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Tower"):
                    if (can_be_build(2, 2))
                    {
                        build_tour_de_garde((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Casern"):
                    if (can_be_build(2, 2))
                    {
                        build_caserne((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Wall"):
                    if (can_be_build(1, 1))
                    {
                        build_rempart((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Temple"):
                    if (can_be_build(4, 5))
                    {
                        build_temple((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Lab"):
                    if (can_be_build(3, 4))
                    {
                        build_laboratoire((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Bank"):
                    if (can_be_build(3, 3))
                    {
                        build_banque((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Mine"):
                    if (can_be_build(2, 2))
                    {
                        build_mine_zinc((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Carrier"):
                    if (can_be_build(2, 2))
                    {
                        build_carriere_roche_volcanique((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                case ("Center"):
                    if (can_be_build(2, 2))
                    {
                        build_centre_extraction_uranium((int)this.transform.position.x, (int)this.transform.position.z);
                    }
                    break;
                default:
                    Debug.Log("BATIMENT INCONNU: " + tag);
                    break;
            }
        }
    }

    void build_donjon(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Donjon";
        cube.transform.transform.localScale = new Vector3(5, 14, 5);
        cube.transform.position = new Vector3(x, 7, z);
    }

    void build_tour_de_garde(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Tower";
        cube.transform.transform.localScale = new Vector3(2, 12, 2);
        cube.transform.position = new Vector3(x, 6, z);
    }

    void build_caserne(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Casern";
        cube.transform.transform.localScale = new Vector3(4, 10, 4);
        cube.transform.position = new Vector3(x, 5, z);
    }

    void build_rempart(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Wall";
        cube.transform.transform.localScale = new Vector3(1, 12, 1);
        cube.transform.position = new Vector3(x, 6, z);
    }

    void build_temple(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Temple";
        cube.transform.transform.localScale = new Vector3(4, 12, 5);
        cube.transform.position = new Vector3(x, 6, z);
    }

    void build_laboratoire(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Lab";
        cube.transform.transform.localScale = new Vector3(3, 10, 4);
        cube.transform.position = new Vector3(x, 5, z);
    }

    void build_banque(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Bank";
        cube.transform.transform.localScale = new Vector3(3, 10, 3);
        cube.transform.position = new Vector3(x, 5, z);
    }

    void build_mine_zinc(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Mine";
        cube.transform.transform.localScale = new Vector3(2, 6, 2);
        cube.transform.position = new Vector3(x, 3, z);
    }

    void build_carriere_roche_volcanique(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Carrier";
        cube.transform.transform.localScale = new Vector3(2, 6, 2);
        cube.transform.position = new Vector3(x, 3, z);
    }

    void build_centre_extraction_uranium(int x, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<collision>();
        cube.name = "Center";
        cube.transform.transform.localScale = new Vector3(2, 8, 2);
        cube.transform.position = new Vector3(x, 4, z);
    }
}
