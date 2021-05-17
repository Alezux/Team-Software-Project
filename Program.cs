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

            WildAnimal wolf = new WildAnimal("Wolf");
            WildAnimal tiger = new WildAnimal("Tiger");
            WildAnimal bear = new WildAnimal("Bear");

            //Console asks user to select list of animals or quit
            Console.WriteLine("Enter 1 to get a list of Animals\nEnter 2 to Quit\n");

            //Loop for getting user input
            while (again)
            {
                //Getting user input
                int input1 = Convert.ToInt32(Console.ReadLine());

                //List of Animals
                if (input1 == 1)
                {
                    //Console asks user to select list of pets, list of wild animals or quit
                    Console.WriteLine("\nEnter 1 to get a list of Pets\nEnter 2 to get a list of Wild Animals\nEnter 3 to Quit\n");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    //Pets List
                    if (input2 == 1)
                    {
                        //For Jussi
                    }

                    //Wild Animals List
                    if (input2 == 2)
                    {
                        //Console displays the list of Wild Animals
                        Console.WriteLine("\nList of Wild Animals:\n" + "\n" + wolf + "\n" + tiger + "\n" + bear + "\n");

                        //Console asks user to select animal from list
                        Console.WriteLine("Which animal would you like to see?\n\nEnter 1 for Wolf\nEnter 2 for Tiger\nEnter 3 for Bear\nEnter 4 to Quit\n");
                        int input3 = Convert.ToInt32(Console.ReadLine());

                        //Wolf
                        while (input3 == 1)
                        {
                            //Console asks user to select what they want to do with animal or quit
                            Console.WriteLine("\nWhat do you want Wolf to do?\n\nEnter 1 to MakeSound\nEnter 2 to Hunt\nEnter 3 to Quit\n");
                            int input4 = Convert.ToInt32(Console.ReadLine());

                            //Wolf MakeSound
                            if (input4 == 1)
                            {
                                Console.WriteLine();
                                wolf.makeSound();
                            }

                            //Wolf Hunt
                            if (input4 == 2)
                            {
                                Console.WriteLine();
                                wolf.hunt();
                            }

                            //Console quits
                            else if (input4 == 3)
                            {
                                again = false;
                                break;
                            }
                        }

                        //Tiger
                        while (input3 == 2)
                        {
                            //Console asks user to select what they want to do with animal or quit
                            Console.WriteLine("What do you want Tiger to do?\n\nEnter 1 to MakeSound\nEnter 2 to Hunt\nEnter 3 to Quit\n");
                            int input4 = Convert.ToInt32(Console.ReadLine());

                            //Tiger MakeSound
                            if (input4 == 1)
                            {
                                Console.WriteLine();
                                tiger.makeSound();
                            }

                            //Tiger Hunt
                            if (input4 == 2)
                            {
                                Console.WriteLine();
                                tiger.hunt();
                            }

                            //Console quits
                            else if (input4 == 3)
                            {
                                again = false;
                                break;
                            }
                        }

                        //Bear
                        while (input3 == 3)
                        {
                            //Console asks user to select what they want to do with animal or quit
                            Console.WriteLine("What do you want Bear to do?\n\nEnter 1 to MakeSound\nEnter 2 to Hunt\nEnter 3 to Quit\n");
                            int input4 = Convert.ToInt32(Console.ReadLine());

                            //Bear MakeSound
                            if (input4 == 1)
                            {
                                Console.WriteLine();
                                bear.makeSound();
                            }

                            //Bear Hunt
                            if (input4 == 2)
                            {
                                Console.WriteLine();
                                bear.hunt();
                            }

                            //Console quits
                            else if (input4 == 3)
                            {
                                again = false;
                                break;
                            }
                        }

                        //Console quits
                        if (input3 == 4)
                        {
                            break;
                        }
                    }

                    //Console quits
                    if (input2 == 3)
                    {
                        break;
                    }
                }

                //Console quits
                if (input1 == 2)
                {
                    break;
                }

                //When bool is false, loop breaks and console quits
                if (again == false)
                {
                    break;
                }
            }
        }
    }
}
