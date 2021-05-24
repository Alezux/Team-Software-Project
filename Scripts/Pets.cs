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

        //Different sounds that animal can make.
        private string[] sounds = { "growls", "farts", "breaks a branch", "yawns", "snorts" };

        public Pets(string animal)
        {
            this.Animal = animal;
            this.Name = "";
        }
        public override string ToString()
        {
            if (this.Name == "")
            {
                return this.Animal;
            }

            else
            {
                return this.Name;
            }
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
            Console.WriteLine(this + " ate, gains " + 1 + "kg and now weighs " + this.weight + " kg");
        }
        public virtual void TalkToOwner()
        {
            Console.WriteLine(this + " talked to owner.");
        }
        public void ComeHere()
        {
            Console.WriteLine(this + " came to owner.");
        }

        public void MakeSound()
        {
            //Animal makes one of the sounds in array "sounds".
            Random rnd = new Random();
            string sound = sounds[rnd.Next(this.sounds.Length)];
            Console.WriteLine("\n" + this + " " + sound + ".");
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
            Console.WriteLine(this.Animal + "'s name is now " + this);
        }
        public override void TalkToOwner()
        {
            Console.WriteLine(this + " meowed at owner");
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
        Console.WriteLine(this.Animal + "'s name is now " + this);
    }

    public override void TalkToOwner()
    {
        Console.WriteLine(this + " barked at owner");
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
        Console.WriteLine(this.Animal + "'s name is now " + this);
    }
    public override void TalkToOwner()
    {
        Console.WriteLine(this + " tweeted at owner");
    }
}
