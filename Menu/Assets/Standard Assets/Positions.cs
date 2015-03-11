using UnityEngine;
using System.Collections;

public class Positions : MonoBehaviour
{
    
    public float x;
    public float y;
    private Renderer rend;
    public float heigth;
    public float width;

    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;

        rend = GetComponent<Renderer>();
        Vector3 size = rend.bounds.size;

        width = size.x;
        heigth = size.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
