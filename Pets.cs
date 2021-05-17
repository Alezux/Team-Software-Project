using System;
using ConsoleApp_2;

namespace ConsoleApp_2
{
    public class Pets
    {
        public string Animal { get; set; }
        public int weight { get; set; }
        public string Name { get; set; }

        public Pets(string animal)
        {
            this.Animal = animal;
        }

        public virtual void Givename(string Name)
        {
            this.Name = Name;
        }
     
        public virtual void Eat()
        {
            //Random rnd = new Random();
            //int food = rnd.Next(4) + 1;
            this.weight += 1;
            Console.WriteLine(this.Name + " ate, gains " + 1 + "kg and now weighs " + this.weight + " kg"  );
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
    public class Cat : Pets
    {

        public Cat(string animal)
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
            Console.WriteLine(this.Name +" meowed at owner");
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








/*What do you want to do? [list, quit]
> list
List of animals:
Wolf
Tiger
Bear
Dog
Dog
Bird
Which animal do you want to see?
> Dog

What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]
> ComeHere

Dog came to the owner.
What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]
> GiveName

Give a name:
> Garfield

What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]
> Eat

Garfield gained 1 kg, and weighs now 1 kg.
What do you want to do? [list, quit]
> quit*/
