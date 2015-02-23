using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        gameObject.name = "Kelmatou";
        gameObject.transform.position = new Vector3(42, 0, 42);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1, 0, 1)); //go up and left
                }
            }
            else if(Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.z > 0 && gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1, 0, -1)); //go up and right
                }
            }
            else if (gameObject.transform.position.x < 400)
            {
                gameObject.transform.Translate(new Vector3(1, 0, 0)); //go up
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.z < 400 && gameObject.transform.position.x > 0)
                {
                    gameObject.transform.Translate(new Vector3(-1, 0, 1)); //go down and left
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.z > 0 && gameObject.transform.position.x > 0)
                {
                    gameObject.transform.Translate(new Vector3(-1, 0, -1)); //go down and right
                }
            }
            else if(gameObject.transform.position.x > 0)
            {
                gameObject.transform.Translate(new Vector3(-1, 0, 0)); //go down
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.z < 400)
            {
                gameObject.transform.Translate(new Vector3(0, 0, 1)); //go left
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.z > 0)
            {
                gameObject.transform.Translate(new Vector3(0, 0, -1)); //go right
            }
        }
    }

}
