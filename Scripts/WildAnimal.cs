using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_2
{
    public class WildAnimal
    {
        private string animal;
        private int weight;

        //Different sounds that animal can make.
        private string[] sounds = { "growls", "farts", "breaks a branch", "yawns", "snorts" };

        public WildAnimal(string animal)
        {
            //Initialization of animal
            this.animal = animal;
        }

        public override string ToString()
        {
            return this.animal;
        }

        public void hunt()
        {
            Random rnd = new Random();
            int huntResult = rnd.Next(10);
            //Animal has 60% change for successful hunt. Hunt is success when huntResult is between 0 - 5
            //and failure if it is between 6 - 9;
            if (huntResult <= 5)
            {
                //Animal finds food and gains betwen 1 to 5 kg more weight.
                int food = rnd.Next(4) + 1;
                this.weight += food;
                Console.WriteLine(this.animal + " finds food, gains " + food + " kg and weighs now " + weight + " kg.");
            }

            else
            {
                //Animal doesn't find food and weight doesn't change.
                Console.WriteLine(this.animal + " does not find food and weighs now " + weight + " kg.");
            }
        }

        public void makeSound()
        {
            //Animal makes one of the sounds in array "sounds".
            Random rnd = new Random();
            string sound = sounds[rnd.Next(this.sounds.Length)];
            Console.WriteLine(animal + " " + sound + ".");
        }
    }
}
