using System;

public class Dog : Animal
{
    //characteristics

    
    public Dog()
    {
        NumLegs = 4;
    }

    //behaviors

    public void WagTail() {
        Console.WriteLine("Wagging Tail!");
    }
}