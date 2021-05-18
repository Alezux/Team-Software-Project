using System;
using ConsoleApp_2;

namespace ConsoleApp_2
{
    public class Pets
    {
        //initialization of object attributes
        // initialized with public because it is the parent class
        public string Animal { get; set; }
        public int weight { get; set; }
        public string Name { get; set; }

        public Pets(string animal)
        {
            this.Animal = animal;
        }
        public override string ToString()
        {
            return this.Animal;
        }

        // virtual keyword because it'll be inherited and editted by child class
        public virtual void Givename(string Name)
        {
            this.Name = Name;
        }

        public virtual void Eat()
        {
            //Random rnd = new Random();
            //int food = rnd.Next(4) + 1;
            this.weight += 1;
            Console.WriteLine(this.Name + " ate, gains " + 1 + "kg and now weighs " + this.weight + " kg");
        }
        public virtual void TalkToOwner()
        {
            Console.WriteLine(this.Name + " talked to owner.");
        }
        public void ComeHere()
        {
            Console.WriteLine(this.Name + " came to owner.");
        }

    }
    // cat class inheriting from pets
    public class Cat : Pets
    {

        public Cat(string animal)
            : base(animal)
        {

        }
        // override method to be able change how method works
        public override void Givename(string Name)
        {
            this.Name = Name;
            Console.WriteLine(this.Animal + "'s name is now " + this.Name);
        }
        public override void TalkToOwner()
        {
            Console.WriteLine(this.Name + " meowed at owner");
        }

    }
}
public class Dog : Pets
{

    public Dog(string animal)
        : base(animal)
    {

    }
    public override void Givename(string Name)
    {
        this.Name = Name;
        Console.WriteLine(this.Animal + "'s name is now " + this.Name);
    }

    public override void TalkToOwner()
    {
        Console.WriteLine(this.Name + " barked at owner");
    }
}
public class Bird : Pets
{

    public Bird(string animal)
        : base(animal)
    {

    }
    public override void Givename(string Name)
    {
        this.Name = Name;
        Console.WriteLine(this.Animal + "'s name is now " + this.Name);
    }
    public override void TalkToOwner()
    {
        Console.WriteLine(this.Name + " tweeted at owner");
    }
}
