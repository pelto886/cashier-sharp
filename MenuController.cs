using System;

public class MenuController
{
    public void Run()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Menu");
            Console.WriteLine("1. New Customer");
            Console.WriteLine("2. Administration");
            Console.WriteLine("0. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("New Customer selected.");
                    // Add code to handle New Customer option here
                    break;
                case "2":
                    Console.WriteLine("Administration selected.");

                    bool adminExit = false;

                    while (!adminExit)
                    {
                        Console.WriteLine("Administration Menu:");
                        Console.WriteLine("1. List products");
                        Console.WriteLine("2. Add product");
                        Console.WriteLine("3. Update product");
                        Console.WriteLine("4. Delete product");
                        Console.WriteLine("0. Back");

                        string adminInput = Console.ReadLine();

                        switch (adminInput)
                        {
                            case "1":
                                Console.WriteLine("List products selected.");
                                break;
                            case "2":
                                Console.WriteLine("Add product selected.");
                                // Add code to handle Add product option here
                                break;
                            case "3":
                                Console.WriteLine("Update product selected.");
                                // Add code to handle Update product option here
                                break;
                            case "4":
                                Console.WriteLine("Delete product selected.");
                                // Add code to handle Delete product option here
                                break;
                            case "0":
                                Console.WriteLine("Returning to main menu.");
                                adminExit = true;
                                break;
                            default:
                                Console.WriteLine("Invalid option selected. Please try again.");
                                break;
                        }

                        Console.WriteLine();
                    }

                    break;
                case "0":
                    Console.WriteLine("Exiting menu.");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option selected. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
