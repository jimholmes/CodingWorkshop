using System;

public class Animal {
    //characteristics
    public string Color;
    private int respirationRate;

    public int NumLegs;

    public int RespirationRate { 
        get => respirationRate; 
        }

    public Animal()
    {
        Color = "White";
        respirationRate = 5;
    }


    //behaviors
    public void Move(int speed) {
        respirationRate += speed;
        Console.WriteLine("Moving at speed: " + speed);
    }

}