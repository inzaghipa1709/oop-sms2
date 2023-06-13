using System;
 
namespace SoalNo5
{
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Cat : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Cat says : Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat(); // Create a Cat object
            myCat.animalSound();  // Call the abstract method
            myCat.sleep();  // Call the regular method
        }
    }
}