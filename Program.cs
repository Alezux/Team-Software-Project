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
            List<WildAnimal> wilds = new List<WildAnimal>();
            wilds.Add(new WildAnimal("Wolf"));
            wilds.Add(new WildAnimal("Tiger"));
            wilds.Add(new WildAnimal("Bear"));


            //Loop for getting user input
            while (again)
            {
                //Console asks user to select list of animals or quit
                Console.WriteLine("Enter 1 to get a list of Animals\nEnter 2 to Quit\n");
                //Getting user input
                int input1 = askNumber(1,2);

                //List of Animals
                if (input1 == 1)
                {
                    while (again)
                    {
                        //Console asks user to select list of pets, list of wild animals or quit
                        Console.WriteLine("\nEnter 1 to get a list of Pets\nEnter 2 to get a list of Wild Animals\n" +
                            "Enter 3 to go back\nEnter 4 to Quit\n");
                        int input2 = askNumber(1, 4);

                        //Pets List
                        if (input2 == 1)
                        {
                            //For Jussi
                            Console.WriteLine("To be added.");
                        }

                        //Wild Animals List
                        else if (input2 == 2)
                        {
                            while (again)
                            {
                                //Console displays the list of Wild Animals
                                Console.WriteLine("\nList of Wild Animals:\n");
                                foreach (WildAnimal animal in wilds)
                                {
                                    Console.Write(animal + "\n");
                                }

                                //Console asks user to select animal from list
                                Console.WriteLine("Which animal would you like to see?)\n");

                                for (int i = 1; i <= wilds.Count(); i++)
                                {
                                    Console.WriteLine("Enter " + i + " for " + wilds[i-1]);
                                }
                                Console.WriteLine("Enter 3 to go back");
                                Console.WriteLine("Enter 4 to Quit\n");

                                int input3 = askNumber(1, 4);
                                if (input3 < 4)
                                {
                                    while (again)
                                    {
                                        //Console asks user to select what they want to do with animal or quit
                                        Console.WriteLine("\nWhat do you want " + wilds[input3-1] + " to do?\n\nEnter 1 to MakeSound\nEnter 2 to Hunt\n" +
                                            "Enter 3 to go back\nEnter 4 to Quit\n");
                                        int input4 = askNumber(1, 4);

                                        //Wolf MakeSound
                                        if (input4 == 1)
                                        {
                                            Console.WriteLine();
                                            wilds[input3 - 1].makeSound();
                                        }

                                        //Wolf Hunt
                                        else if (input4 == 2)
                                        {
                                            Console.WriteLine();
                                            wilds[input3 - 1].hunt();
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
                    Console.WriteLine("Error. Input a number between " + start + " and " + end );
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