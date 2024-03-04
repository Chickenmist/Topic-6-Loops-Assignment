﻿namespace Topic_6__Loops__Assignment
{
    internal class Program
    {

        //Wilson

        static void Main(string[] args)
        {
            int running = 1; //1 means program is running, 0 will end it
            int choice = 0;

            while (running == 1)
            {
                choice = 0;
                
                Console.WriteLine("Choose what program to run or if you want to quit: ");
                Console.WriteLine("");
                Console.WriteLine("1. Number Prompter   2. Percent Passing");
                Console.WriteLine("3. Odd Sum           4. Random Numbers");
                Console.WriteLine("             5. Quit");
                Console.WriteLine("");

                while (choice == 0)
                {
                    Console.Write("Selection: ");
                    int.TryParse(Console.ReadLine(), out choice);

                    if (choice == 1)
                    {
                        Prompter();
                    }
                    else if (choice == 2)
                    {
                        PercentPassing();
                    }
                    else if (choice == 3)
                    {
                        OddSum();
                    }
                    else if (choice == 4)
                    {
                        RandomNumbers();
                    }
                    else if (choice == 5)
                    {
                        running++;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid selection");
                        Console.WriteLine("");
                    }
                }
            }
        }

        static void Prompter() //Part 1
        {
            int min = -1, max = -1, number = -1;
            string inputMin, inputMax, inputNumber;

            Console.WriteLine("");
            Console.WriteLine("-------Number Prompter-------");

            while (min == -1)
            {
                Console.Write("Enter a minimum (cannot be negative): ");
                inputMin = Console.ReadLine();
                int.TryParse(inputMin, out min);

                if (min < 0)
                {
                    min = -1;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Minimum is {min}");
                }
                Console.WriteLine("");
            }

            while (max == -1)
            {
                Console.Write("Enter a maximum (cannot be negative or less than the min): ");
                inputMax = Console.ReadLine();
                int.TryParse(inputMax, out max);

                if (inputMax == "" || max < 0 || max <= min) 
                {
                    max = -1;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Maximum is {max}");
                }
                Console.WriteLine("");
            }

            while (number == -1)
            {
                Console.Write($"Enter a number between {min} and {max} (inclusive): ");
                inputNumber = Console.ReadLine();
                int.TryParse(inputNumber, out number);

                if (number < 0 || number < min || number > max)
                {
                    number = -1;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine($"The number you chose was {number}");
                }
                Console.WriteLine("");
            }
        }

        static void PercentPassing() //Part 2
        {
            int amount = 0, passed = 0;
            double percentage = 0, scores = 0;

            Console.WriteLine("");
            Console.WriteLine("-------Percent Passing-------");

            while (amount == 0)
            {
                Console.Write("How many percentages do you want to enter: ");
                int.TryParse(Console.ReadLine(), out amount);

                if (amount <= 0)
                {
                    amount = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid");
                    Console.WriteLine("");
                }
            }

            for (int i = 0; i < amount; i++) 
            {
                scores = 0;
                Console.WriteLine("");
                
                while(scores == 0)
                {
                    Console.Write("Enter a percentage: ");
                    double.TryParse(Console.ReadLine(), out scores);

                    if (scores < 0)
                    {
                        scores = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Invalid");
                    }
                    else if (scores > 70)
                    {
                        passed += 1;
                    }
                }
            }

            percentage = (Convert.ToDouble(passed) / Convert.ToDouble(amount)) * 100;
            Console.WriteLine("");
            Console.WriteLine($"{Math.Round(percentage)}% of the scores entered were above 70");
            Console.WriteLine("");
        }

        static void OddSum() //Part 3
        {

        }

        static void RandomNumbers()//Part 4
        {

        }
    }
}