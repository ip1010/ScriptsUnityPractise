using UnityEngine;

public class HealthUpdate : MonoBehaviour
{
    //Declaring the variables
    public int health = 5;
    public int level = 3;
    void Start()
    {
        //Adding level to health and then outputting it
        health += level;
        Debug.Log(health);
    }
}
