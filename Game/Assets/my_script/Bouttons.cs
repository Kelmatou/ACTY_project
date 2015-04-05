using UnityEngine;
using System.Collections;

public class Bouttons : MonoBehaviour 
{

    public void StartGame()
    {
        /*GameObject bouton_jouer = GameObject.Find("Bouton_jouer");
        GameObject bouton_quitter = GameObject.Find("Bouton_quitter");
        GameObject bouton_map1 = GameObject.Find("Bouton_map1");
        GameObject bouton_map2 = GameObject.Find("Bouton_map2");
        GameObject bouton_map3 = GameObject.Find("Bouton_map3");
        bouton_jouer.transform.position = new Vector3(7166, 6436, 0);
        bouton_quitter.transform.position = new Vector3(7166, 6436, 0);
        bouton_map1.transform.position = new Vector3(0, 10, 0);
        bouton_map2.transform.position = new Vector3(0, -20, 0);
        bouton_map3.transform.position = new Vector3(0, -50, 0);*/
        Application.LoadLevel("map_1_selection");
        
    }

    public void launch_map_1()
    {
        Application.LoadLevel("map_1");
    }

    public void launch_map_2()
    {
        Application.LoadLevel("map_2");
    }

    public void launch_map_3()
    {
        Application.LoadLevel("map_3");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
