using UnityEngine;
using System.Collections;

public class God_char : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        gameObject.name = "Kelmatou";
        gameObject.transform.position.Set(200, 0, 200);
    }

    // Update is called once per frame
    void Update()
    {
        int direction = (int)(Random.value * 4);

        switch (direction)
        {
            case (0):
                if (gameObject.transform.position.x < 400)
                {
                    gameObject.transform.Translate(new Vector3(1, 0, 0)); //go up
                }
                break;
            case (1):
                if (gameObject.transform.position.x > 0)
                {
                    gameObject.transform.Translate(new Vector3(-1, 0, 0)); //go down
                }
                break;
            case (2):
                if (gameObject.transform.position.z < 400)
                {
                    gameObject.transform.Translate(new Vector3(0, 0, 1)); //go left
                }
                break;
            case (3):
                if (gameObject.transform.position.z > 0)
                {
                    gameObject.transform.Translate(new Vector3(0, 0, -1)); //go right
                }
                break;
        }
    }

}
