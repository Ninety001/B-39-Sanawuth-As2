using UnityEngine;

public class Dog : Animal
{
    void Start()
    {
        Initialize("Dog", 10.0f, 3.0f, 0.0f, "Meat");

        // ทดสอบการทำงาน
        Move();
        Sleep();
        Fetch();
    }

    // Method for dog
    public void Fetch()
    {
        Debug.Log(Name + " is fetching a ball.");
    }
}
