using UnityEngine;
using System.Collections;

public class units_stat : MonoBehaviour 
{
    int life;
    int armor;
    int damage;
    int timer;

	void Start () 
    {
        life = 40;
        armor = 10;
        damage = 35;
        timer = 700;
	}

    void Update()
    {
        if(timer == 0)
        {
            life = life - damage + armor;
            
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
            timer = 700;
        }
        else
        {
            timer--;
        }
    }
}
