using UnityEngine;
using System.Collections;

public class Spotlight3 : MonoBehaviour
{
    float x;
    float y;
    int i;
    void Start()
    {
        get_x();
        get_y();
    }

    public void get_x()
    {
        x = transform.position.x;
    }

    public void get_y()
    {
        y = transform.position.y;
    }
    void Update()
    {
        transform.Translate(Vector3.up);
        transform.Translate(Vector3.right * 3 / 4);
        i++;
        if (i > 400)
        {
            transform.position = new Vector3(x, y, -1);
            i = 0;
        }
    }
}
