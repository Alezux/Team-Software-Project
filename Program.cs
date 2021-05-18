using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool again = true;

            //List of pets
            List<Pets> pets = new List<Pets>();
            pets.Add(new Bird("Bird"));
            pets.Add(new Cat("Cat"));
            pets.Add(new Dog("Dog"));

            //List of wild animals
            List<WildAnimal> wildanimal = new List<WildAnimal>();
            wildanimal.Add(new WildAnimal("Wolf"));
            wildanimal.Add(new WildAnimal("Tiger"));
            wildanimal.Add(new WildAnimal("Bear"));


            //Loop for getting user input
            while (again)
            {
                //Console asks user to select list of animals or quit
                Console.WriteLine("Enter 1 to get a list of Animals\nEnter 2 to quit\n");

                //Getting user input
                int input1 = askNumber(1, 2);

                //List of Animals
                if (input1 == 1)
                {
                    while (again)
                    {
                        //Console asks user to select list of pets, list of wild animals or quit
                        Console.WriteLine("\nEnter 1 to get a list of Pets\nEnter 2 to get a list of Wild Animals\n" +
                        "Enter 3 to go back\nEnter 4 to quit\n");
                        int input2 = askNumber(1, 4);

                        //Pets List
                        if (input2 == 1)
                        {
                            while (again)
                            {
                                Console.WriteLine("\nList of Pets:\n");

                                foreach (Pets animal in pets)
                                {
                                    Console.WriteLine(animal);
                                }

                                //Console asks user to select animal from list
                                Console.WriteLine("\nWhich animal would you like to see?\n");

                                for (int i = 1; i <= pets.Count(); i++)
                                {
                                    Console.WriteLine("Enter " + i + " for " + pets[i - 1]);
                                }

                                Console.WriteLine("Enter 4 to go back");
                                Console.WriteLine("Enter 5 to quit\n");

                                int input3 = askNumber(1, 5);

                                if (input3 < 4)
                                {
                                    while (again)
                                    {
                                        Console.WriteLine("\nWhat do you want " + pets[input3 - 1] + " to do?\n\nEnter 1 to Eat\nEnter 2 to TalkToOwner\nEnter 3 to MakeSound\n" +
                                        "Enter 4 to ComeHere\nEnter 5 to GiveName\nEnter 6 to go back\nEnter 7 to quit\n");

                                        int input4 = askNumber(1, 7);

                                        if (input4 == 1)
                                        {
                                            Console.WriteLine();
                                            pets[input3 - 1].Eat();
                                        }

                                        else if (input4 == 2)
                                        {
                                            Console.WriteLine();
                                            pets[input3 - 1].TalkToOwner();
                                        }

                                        else if (input4 == 3)
                                        {
                                            pets[input3 - 1].MakeSound();
                                        }

                                        else if (input4 == 4)
                                        {
                                            pets[input3 - 1].ComeHere();
                                        }

                                        else if (input4 == 5)
                                        {
                                            Console.WriteLine("\nGive name for " + pets[3 - 1] + "\n");
                                            string name = Console.ReadLine();
                                            Console.WriteLine();
                                            pets[3 - 1].Givename(name);
                                        }

                                        else if (input4 == 6)
                                        {
                                            break;
                                        }

                                        else if (input4 == 7)
                                        {
                                            again = false;
                                        }
                                    }
                                }

                                else if (input3 == 4)
                                {
                                    break;
                                }

                                else if (input3 == 5)
                                {
                                    again = false;
                                }

                            }
                        }

                        //Wild Animals List
                        else if (input2 == 2)
                        {
                            while (again)
                            {
                                //Console displays the list of Wild Animals
                                Console.WriteLine("\nList of Wild Animals:\n");

                                foreach (WildAnimal animal in wildanimal)
                                {
                                    Console.Write(animal + "\n");
                                }

                                //Console asks user to select animal from list
                                Console.WriteLine("\nWhich animal would you like to see?\n");

                                for (int i = 1; i <= wildanimal.Count(); i++)
                                {
                                    Console.WriteLine("Enter " + i + " for " + wildanimal[i - 1]);
                                }

                                Console.WriteLine("Enter 4 to go back");
                                Console.WriteLine("Enter 5 to quit\n");

                                int input3 = askNumber(1, 5);

                                if (input3 < 4)
                                {
                                    while (again)
                                    {
                                        //Console asks user to select what they want to do with animal or quit
                                        Console.WriteLine("\nWhat do you want " + wildanimal[input3 - 1] + " to do?\n\nEnter 1 to MakeSound\nEnter 2 to Hunt\n" +
                                        "Enter 3 to go back\nEnter 4 to Quit\n");
                                        int input4 = askNumber(1, 4);

                                        //MakeSound
                                        if (input4 == 1)
                                        {
                                            Console.WriteLine();
                                            wildanimal[input3 - 1].makeSound();
                                        }

                                        //Hunt
                                        else if (input4 == 2)
                                        {
                                            Console.WriteLine();
                                            wildanimal[input3 - 1].hunt();
                                        }

                                        //Console quits
                                        else if (input4 == 3)
                                        {
                                            break;
                                        }

                                        else if (input4 == 4)
                                        {
                                            again = false;
                                        }
                                    }
                                }
                                //Console quits
                                else if (input3 == 4)
                                {
                                    break;
                                }

                                else if (input3 == 5)
                                {
                                    again = false;
                                }
                            }
                        }
                        //Console quits
                        else if (input2 == 3)
                        {
                            break;
                        }
                        else if (input2 == 4)
                        {
                            again = false;
                        }
                    }
                }

                //Console quits
                else if (input1 == 2)
                {
                    break;
                }
            }
        }

        public static int askNumber(int start, int end)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input <= end & input >= start)
                {
                    return input;
                }

                else
                {
                    Console.WriteLine("Error. Input a number between " + start + " and " + end);
                    return input;
                }
            }

            catch
            {
                Console.WriteLine("Error. Input is not a number");
                return -1;
            }
        }
    }
}
