using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HelloWorld();
            CreateAnimal();
            CreateDog();
            CreateBrittanySpaniel();
            BranchingExample(); */
            DoWhileLoop();
            WhileDoLoop();
        }

        private const int BOUNDARY = 0;
        static int index = 0;

        private static void WhileDoLoop()
        {
            index = 0;
            Console.WriteLine("WhileDo");
            while (index < BOUNDARY)
            {
                Console.WriteLine("Idx:" + index);
                index++;
                
            }
        }
        private static void DoWhileLoop()
        {
            index = 0;
            Console.WriteLine("DoWhile");
            do
            {
                Console.WriteLine("Idx: " + index);
                index++;
            } while (index < BOUNDARY);
        }

        private static void BranchingExample()
        {
            int num = 1;
            if (num == 0)
            {
                Console.WriteLine("It's Zero!");
            }else if (num == 2){
                Console.WriteLine("It's two!");
            }else {
                Console.WriteLine("I don't know what number it is!");
            }

            switch (num)
            {
                case 1: 
                    Console.WriteLine("1");
                    break;
                case 2: 
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Don't know");
                    break;
            }
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void CreateBrittanySpaniel()
        {
            BrittanySpaniel gus = new BrittanySpaniel();
            Console.WriteLine("Gus's color: " + gus.Color);
        }

        private static void CreateDog()
        {
            Dog myDog = new Dog();
            Console.WriteLine("NumLegs: " + myDog.NumLegs);
            myDog.WagTail();
        }

        static public void CreateAnimal() {
            Animal myAnimal = new Animal();
            Console.WriteLine("Respiration: " + myAnimal.RespirationRate);
            myAnimal.Color = "Red";
            Console.WriteLine("Animal Color: " + myAnimal.Color);
            int speed = 5;
            myAnimal.Move(speed);
            Console.WriteLine("Respiration: " + myAnimal.RespirationRate);
        }
    }
}
