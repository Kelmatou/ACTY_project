using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour 
{

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Cube Collision");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");
    }
}
