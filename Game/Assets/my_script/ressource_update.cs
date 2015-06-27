using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ressource_update : MonoBehaviour
{
    //GameObject ressource_text_zinc;
    //GameObject ressource_text_rock;
    //GameObject ressource_text_uranium;

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

    //public Button Mine;
    //public Button Carrier;
    //public Button Center;

    void Start()
    {
        //if (this.name == "Button_Mine")
        //{
        //    ressource_text_zinc = GameObject.Find("Tooltip_Zinc");
        //    Debug.Log("OK1 " + ressource_text_zinc.name);
        //    ressource_text_zinc.GetComponentInChildren<Text>().text = value_zinc.ToString();
        //}
        //else if (this.name == "Button_Carrier")
        //{
        //    ressource_text_rock = GameObject.Find("Tooltip_Rock");
        //    Debug.Log("OK2 " + ressource_text_rock.name);
        //    ressource_text_rock.GetComponentInChildren<Text>().text = value_rock.ToString();
        //}
        //else if (this.name == "Button_Center")
        //{
        //    ressource_text_uranium = GameObject.Find("Tooltip_Uranium");
        //    Debug.Log("OK3 " + ressource_text_uranium.name);
        //    ressource_text_uranium.GetComponentInChildren<Text>().text = value_uranium.ToString();
        //}
        Zinc.text = value_zinc.ToString();
        Debug.Log(Zinc.text);
        Rock.text = value_rock.ToString();
        Uranium.text = value_uranium.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > update_time)
        {
            update_time = Time.time + period;

            value_zinc = (value_zinc + building_zinc);
            Zinc.text = ((int)value_zinc).ToString();
            //ressource_text_zinc.GetComponentInChildren<Text>().text = value_zinc.ToString();
            value_rock = value_rock + building_rock;
            Rock.text = value_rock.ToString();
            //ressource_text_rock.GetComponentInChildren<Text>().text = value_rock.ToString();
            value_uranium = value_uranium + building_uranium;
            Uranium.text = value_uranium.ToString();
            //ressource_text_uranium.GetComponentInChildren<Text>().text = value_uranium.ToString();
        }
        Debug.Log("Z: " + value_zinc + "   R: " + value_rock + "   U: " + value_uranium);
    }

    public void add_building_mine()
    {
        building_zinc++;
    }
    public void add_building_carrier()
    {
        building_rock++;
    }
    public void add_building_center()
    {
        building_uranium++;
    }

    public bool enough_ressources(float z, float r, float u)
    {
        return (value_zinc >= z && value_rock >= r && value_uranium >= u);
    }

}
