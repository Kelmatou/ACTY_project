using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    int movespeed;

    // Use this for initialization
    void Start()
    {
        gameObject.name = "Kelmatou";
        movespeed = 2;
        gameObject.transform.position = new Vector3(42, 0, 42);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject text = GameObject.Find("Display Text");
        if(text.guiText.text != "Pause")
        {
            move(movespeed);
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
                }
            }
            else if(Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.z > 0 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1 * movespeed, 0, -1 * movespeed)); //go up and right
                }
            }
            else if (gameObject.transform.position.x < 400)
            {
                gameObject.transform.Translate(new Vector3(1 * movespeed, 0, 0)); //go up
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x > 0)
                {
                    gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, 1 * movespeed)); //go down and left
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.z > 0 && gameObject.transform.position.x > 0)
                {
                    gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, -1 * movespeed)); //go down and right
                }
            }
            else if(gameObject.transform.position.x > 0)
            {
                gameObject.transform.Translate(new Vector3(-1 * movespeed, 0, 0)); //go down
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.z < 400)
            {
                gameObject.transform.Translate(new Vector3(0, 0, 1 * movespeed)); //go left
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.z > 0)
            {
                gameObject.transform.Translate(new Vector3(0, 0, -1 * movespeed)); //go right
            }
        }
    }

}
