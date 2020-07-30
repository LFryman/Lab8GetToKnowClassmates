using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Lab8GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Lauren", "Sean", "Justin", "Sumana", "Anna", "Ramez", "Joseph", "Annas' Cat", "Robbie", "Simon", "Jordan" };
            List<string> favoriteColor = new List<string>() { "purple", "pink", "blue", "green", "yello", "orand", "pomagranate", "black", "brown", "gray", "red" };
            List<string> favoriteFood = new List<string>() { "fish tacos", "fish and chips", "chocolate", "peanut butter and jelly", "poptarts", "spagetti", "soup", "human food of any kind", "bread pudding", "steak" };

            bool lContinue = true;
            while (lContinue)
            {

                Console.WriteLine("What student would you like to learn about? Enter the number next to their name.");

                DisplayStudent(names);

                try
                {
                    int student = int.Parse(Console.ReadLine()) - 1;

                    if (student <= 10 && student >= 0)
                    {

                        Console.WriteLine($"You have chosen {names[student]}, would you like to know their favorite color, favorite food or both?");


                        bool a = true;
                        while (a == true)
                        {
                            Console.WriteLine("Please enter in the format of - color - food - both.");
                            string response = Console.ReadLine();

                            bool vResponse = ValidateFavorite(response);


                            if (response == "color")
                            {
                                Console.WriteLine($"Their favorite color is {favoriteColor[student]}");
                                a = false;
                            }
                            else if (response == "food")
                            {
                                Console.WriteLine($"Their favorite food is {favoriteFood[student]}");
                                a = false;
                            }
                            else if (response == "both")
                            {
                                Console.WriteLine($"Wow! You sure are interested.");
                                Console.WriteLine($"{names} favorit color is {favoriteColor[student]}.");
                                Console.WriteLine($"And their favorit food is {favoriteFood[student]}.");
                                a = false;
                            }

                            else
                            {
                                Console.WriteLine("That's not what I asked. Enter color, food or both.");
                                Console.WriteLine("Press any key to try again");
                                Console.ReadKey();
                                Console.Clear();
                                a = true;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("I highly suggest a number from 1 - 10. Try again.");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("That input was not a number");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();

                }
                Console.WriteLine("Would you like to get to know another student? y/n");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {
                    lContinue = true;
                }
                else
                {
                    lContinue = false;
                    Console.WriteLine("Come again!");
                }
            }
        }
        public static void DisplayStudent(List<string> names)
        {

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {names[i]}");
            }
        }

        public static bool ValidateFavorite(string fav)
        {
            if (fav == "color" || fav == "food" || fav == "both")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
