using UnityEngine;
using System.Collections;

public class unit_leader : MonoBehaviour 
{
    int life;
    int armor;
    int damage;
    int timer;

    void Start()
    {
        life = 250;
        armor = 20;
        damage = 35;
        timer = 700;
        gameObject.transform.position = new Vector3(42, 5, 42);
    }

    void Update()
    {
        if (timer == 0)
        {
            life = life - damage + armor;

            if (life <= 0)
            {
                this.transform.position = new Vector3(42, 5, 42);
                this.transform.Rotate(new Vector3(0, 180, 0));
            }
            timer = 700;
        }
        else
        {
            timer--;
        }
    }
}
