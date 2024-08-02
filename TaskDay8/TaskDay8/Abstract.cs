namespace TaskDay8
{
    using System;


    public abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class Abstract
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Dog myDog = new Dog();

            myDog.SetName(dogName);

            Console.WriteLine(myDog.GetName());

            myDog.Eat();
        }
    }
} 