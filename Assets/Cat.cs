using UnityEngine;

public class Cat : Animal
{
    void Start()
    {   

        Initialize("Cat", 10.0f, 3.0f, 0.0f, "Meat");

        Eat();
        Move();
        Climb();
    }

    // Method for cat
    public void Climb()
    {
        Debug.Log(Name + " is climbing.");
    }
}
