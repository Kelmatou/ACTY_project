using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ressource_update : MonoBehaviour
{
    public float value_zinc;
    public float value_rock;
    public float value_uranium;

    public int building_zinc;
    public int building_rock;
    public int building_uranium;

    public Text Zinc;
    public Text Rock;
    public Text Uranium;

    private float update_time = 0;
    private float period = 0.5F;

    public Button Mine;
    public Button Carrier;
    public Button Center;
    public Button Lab;
    public Button Wall;
    public Button Donjon;
    public Button Tower;
    public Button Temple;
    public Button Caserne;
    public Button Bank;

    private int max_capacity;

    void Start()
    {
        max_capacity = 300;
        Zinc.text = value_zinc.ToString();
        Rock.text = value_rock.ToString();
        Uranium.text = value_uranium.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > update_time)
        {
            update_time = Time.time + period;
            if (value_zinc < max_capacity)
            {
                value_zinc = (value_zinc + building_zinc);
                Zinc.text = value_zinc.ToString();
            }
            if (value_rock < max_capacity)
            {
                value_rock = value_rock + building_rock;
                Rock.text = value_rock.ToString();
            }
            if (value_uranium < max_capacity)
            {
                value_uranium = value_uranium + building_uranium;
                Uranium.text = value_uranium.ToString();
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(value_zinc <= max_capacity - 100)
            {
                value_zinc = value_zinc + 100;
                
            }
            else
            {
                value_zinc = max_capacity;
            }
            if (value_rock <= max_capacity - 100)
            {
                value_rock = value_rock + 100;
            }
            else
            {
                value_rock = max_capacity;
            }
            if (value_uranium <= max_capacity - 100)
            {
                value_uranium = value_uranium + 100;
            }
            else
            {
                value_uranium = max_capacity;
            }

            Zinc.text = value_zinc.ToString();
            Rock.text = value_rock.ToString();
            Uranium.text = value_uranium.ToString();
            
        }
        Debug.Log("Z: " + value_zinc + "   R: " + value_rock + "   U: " + value_uranium + "   MAX: " + max_capacity);
    }

    public void add_building(string name)
    {
        if (Time.timeScale != 0)
        {
            switch (name)
            {
                case ("Center"):
                    value_zinc = value_zinc - 40;
                    value_rock = value_rock - 40;
                    value_uranium = value_uranium - 5;
                    building_uranium++;
                    buildable("Center");
                    break;
                case ("Mine"):
                    value_zinc = value_zinc - 20;
                    value_rock = value_rock - 30;
                    value_uranium = value_uranium - 20;
                    building_zinc++;
                    buildable("Mine");
                    break;
                case ("Carrier"):
                    value_zinc = value_zinc - 30;
                    value_rock = value_rock - 10;
                    value_uranium = value_uranium - 20;
                    building_rock++;
                    buildable("Carrier");
                    break;
                case ("Bank"):
                    value_zinc = value_zinc - 100;
                    value_rock = value_rock - 100;
                    value_uranium = value_uranium - 100;
                    max_capacity = max_capacity + 200;
                    buildable("Bank");
                    break;
                case ("Lab"):
                    value_zinc = value_zinc - 80;
                    value_rock = value_rock - 80;
                    value_uranium = value_uranium - 80;
                    buildable("Lab");
                    break;
                case ("Temple"):
                    value_zinc = value_zinc - 40;
                    value_rock = value_rock - 40;
                    value_uranium = value_uranium - 40;
                    buildable("Temple");
                    break;
                case ("Wall"):
                    value_rock = value_rock - 30;
                    buildable("Wall");
                    break;
                case ("Caserne"):
                    value_zinc = value_zinc - 40;
                    value_rock = value_rock - 20;
                    value_uranium = value_uranium - 10;
                    buildable("Caserne");
                    break;
                case ("Donjon"):
                    value_zinc = value_zinc - 30;
                    value_rock = value_rock - 20;
                    value_uranium = value_uranium - 10;
                    buildable("Donjon");
                    break;
                case ("Tower"):
                    value_zinc = value_zinc - 30;
                    value_rock = value_rock - 30;
                    value_uranium = value_uranium - 15;
                    buildable("Tower");
                    break;
            }
        }
    }

    public void buildable(string name)
    {
        switch (name)
        {
            case ("Center"):
                if (value_zinc < 40 || value_rock < 40 || value_uranium < 5)
                {
                    Center.enabled = false;
                }
                break;
            case ("Mine"):
                if (value_zinc < 20 || value_rock < 30 || value_uranium < 20)
                {
                    Mine.enabled = false;
                }
                break;
            case ("Carrier"):
                if (value_zinc < 30 || value_rock < 10 || value_uranium < 20)
                {
                    Carrier.enabled = false;
                }
                break;
            case ("Bank"):
                if (value_zinc < 100 || value_rock < 100 || value_uranium < 100)
                {
                    Bank.enabled = false;
                }
                break;
            case ("Lab"):
                if (value_zinc < 80 || value_rock < 80 || value_uranium < 80)
                {
                    Lab.enabled = false;
                }
                break;
            case ("Temple"):
                if (value_zinc < 40 || value_rock < 40 || value_uranium < 40)
                {
                    Temple.enabled = false;
                }
                break;
            case ("Wall"):
                if (value_zinc < 0 || value_rock < 30 || value_uranium < 0)
                {
                    Wall.enabled = false;
                }
                break;
            case ("Caserne"):
                if (value_zinc < 40 || value_rock < 20 || value_uranium < 10)
                {
                    Caserne.enabled = false;
                }
                break;
            case ("Donjon"):
                if (value_zinc < 30 || value_rock < 30 || value_uranium < 10)
                {
                    Donjon.enabled = false;
                }
                break;
            case ("Tower"):
                if (value_zinc < 30 || value_rock < 30 || value_uranium < 15)
                {
                    Tower.enabled = false;
                }
                break;
        }
    }

    public void pointer_exit(Button B)
    {
        B.enabled = true;
    }
}