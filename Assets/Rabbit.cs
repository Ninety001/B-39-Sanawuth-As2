using UnityEngine;

public class Rabbit : Animal
{
    void Start()
    {
        Initialize("Rabbit", 10.0f, 3.0f, 0.0f, "Plant");

        // Test
        Move();
        Sleep();
    }
}
