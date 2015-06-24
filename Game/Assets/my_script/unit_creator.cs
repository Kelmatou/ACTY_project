using UnityEngine;
using System.Collections;

public class unit_creator : MonoBehaviour 
{
    int timer;

	void Start () 
    {
        timer = 500;
	}
	
	void Update () 
    {
        if(this.transform.position.y >= 0 && this.transform.position.y < 50)
        {
            if (timer == 0)
            {
                GameObject exemple = GameObject.Find("Player");
                GameObject unit = exemple;
                unit.name = "Player";
                unit = Instantiate(exemple);
                unit.AddComponent<BoxCollider>();
                unit.AddComponent<units_stat>();
                unit.AddComponent<IA>();
                if(unit.GetComponent("unit_leader"))
                {
                    Destroy(unit.GetComponent("unit_leader"));
                }
                if (unit.GetComponent("God_char"))
                {
                    Destroy(unit.GetComponent("God_char"));
                }
                unit.transform.position = new Vector3(this.transform.position.x + 10, 5, this.transform.position.z + 10);
                timer = 500;
            }
            else
            {
                timer--;
            }
        }
	}
}
