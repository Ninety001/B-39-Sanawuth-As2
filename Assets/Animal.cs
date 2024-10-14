using UnityEngine;

public class Animal : MonoBehaviour
{
    // Encapsulation
    protected string animalName;
    protected float health;
    protected float hunger;
    protected float speed;
    protected string foodType;

    // Properties
    public string Name
    {
        get 
        { 
            return animalName;
        }

        set 
        {
            animalName = value; 
        }
    }

    public float Health
    {
        get 
        {
            return health;
        }
        set 
        { 
            health = value;
        }
    }

    public float GetHunger()
    {
        return hunger;
    }
    public void SetHunger(float value)
    {
        hunger = value;
        Debug.Log(Name + "'s hunger is set to " + hunger);
    }


    public void Eating()
    {
        if (foodType == "Plant")
        {
            Debug.Log(Name + " eat Plant.");
        }
        else if (foodType == "Meat")
        {
            Debug.Log(Name + " eat Meat.");
        }
        else
        {
            Debug.Log(Name + " has nothing to eat.");
        }
    }
    // Eating
    public void Eat()
    {
        Debug.Log(Name + " is eating.");
    }

    // Movement
    public void Move()
    {
        Debug.Log(Name + " is move" );
    }

    // Sleep
    public void Sleep()
    {
        Debug.Log(Name + " is sleep.");
    }
    public void Climb()
    {
        Debug.Log(Name + " is climb");
    }
    public void Initialize(string name, float health, float speed, float hunger, string foodType)
    {
        this.animalName = name;
        this.health = health;
        this.speed = speed;
        this.hunger = hunger;
        this.foodType = foodType;

        // Output
        Debug.Log($"{Name} has health: {health}, Speed: {speed}, Hunger: {hunger}");
    }


}
