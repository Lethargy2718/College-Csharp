using System;
using System.Linq;
namespace Discount;

public static class Program

{
    public static void Main()
    {
        // Initializing variables
        bool valid = false;
        double costs = 0;
        int number = 0;
        int tries = 0;
        bool annoyed = false;

        Console.WriteLine("**WELCOME**");
        Console.WriteLine("-----------");
        Console.Write("Enter the shopping costs: ");

        // Cost query
        while (!valid)
        {
            try
            {
                // Checks if "double" is a poitive double.
                costs = double.Parse(Console.ReadLine());
                if (costs <= 0)
                {
                    throw new FormatException();
                }
                valid = true;
            }
            catch (FormatException)
            {
                switch (tries)
                {
                    case 0:
                    case 1:
                        Console.Write("Cost must be a positive number. Please try again: ");
                        break;
                    case 2:
                        Console.WriteLine("Please enter a POSITIVE NUMBER like 1000: ");
                        annoyed = true;
                        break;
                    case 3:
                        // Terminates the program on giving 4 invalid inputs.
                        Console.WriteLine("I am done. Bye.");
                        return;
                }
                tries++;
            }
        };
        Console.WriteLine("-------");
        valid = false;
        tries = 0;

        Console.WriteLine("Please enter the number of things you want to buy: ");

        // Number query
        while (!valid)
        {
            try
            {
                // Checks if "number" is a positive int.
                number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    throw new FormatException();
                }
                valid = true;
            }
            catch (FormatException)
            {
                switch (tries)
                {
                    case 0:
                    case 1:
                        // If the user gives 3 invalid inputs in the first
                        // query then gives one more invalid input in this
                        // one, the program closes the app. 
                        if (annoyed)
                        {
                            Environment.Exit(1);
                        }
                        Console.Write("Number must be positive. Please try again: ");
                        break;
                    case 2:
                        Console.Write("Please enter a POSITIVE NUMBER like 7: ");
                        break;
                    case 3:
                        Console.Write("I am done. Bye.");
                        return;
                }
                tries++;
            }
        };
        Console.WriteLine("-------");
        double totalCost = costs * number;

        // Discount logic
        if (totalCost > 500)
        {
            Console.Write("Total cost after the discount: " + (totalCost * 95 / 100));
            return;
        }
        Console.Write("Total cost: " + totalCost);
    }
}


