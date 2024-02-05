
using System;
using System.Dynamic;

class VirtualPet
{
    private static object happiness;
    private static object hunger;
    private static object health;

    static void Main()

    {
        Console.WriteLine("Welcome to the Virtual Pet Simulation!");

        // Pet creation
        Console.WriteLine("Choose a pet type: (1) Cat, (2) Dog, (3) Rabbit: ");
        int petTypeChoice =
            Convert.ToInt32(Console.ReadLine());
        string petType =
            GetPetType(petTypeChoice);

        Console.WriteLine("Enter your pet's name: ");
        string petName =
           Console.ReadLine();

        // Display welcome message
        Console.WriteLine($"\nCongratulations! you have a new pet named {petName}. It's a {petTypeChoice}.");

        // Simulations logic can be added here
        Console.WriteLine("\nSimulation completed. Goodbye");

        static string GetPetType(int choice)
        {
            switch (choice)
            {
                case 1: return "Cat";
                case 2: return "Dog";
                case 3: return "Rabbit";
                default: return "Unknown";
            }
        }
        //Pet care loop
        while (true)
        {

            // Pet care actions
            Console.WriteLine("\nPet Care Actions");
            Console.WriteLine("1. Feed 2. Play 3. Rest 4. Exit");
            int actionChoice =
                Convert.ToInt32(Console.ReadLine());

            switch (actionChoice)
            {
                case 1: Feed(health, hunger);
                    break;
                case 2:
                    Play();
                    break;
                case 3:
                    Rest();
                    break;
                case 4:

                    Console.WriteLine("Exiting the Virtual Pet Simulator. Goodbye! ");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid action. ");
                    break;
            }
        }
    }
    class virtualPet
    {

        static int hunger = 5;
        static int happiness = 5;
        static int health = 5;
    }
    static void Feed(object health, object hunger)
    {
        hunger = Math.Max(hunger - 2, 1);
        health = Math.Min(health + 1, 10);
        Console.WriteLine("You fed your pet. Hunger decreased, health increased.");
    }

    static void Play()
    {
        happiness = Math.Min(happiness + 2, 10);
        hunger = Math.Min(hunger + 1, 10);
        Console.WriteLine("You played with your pet. Happiness increased, hunger increased");
    }

    static void Rest()
    {
        health = Math.Min(health + 2, 10);
        happiness = Math.Max(happiness - 1, 1);
        Console.WriteLine("Your pet rested. Health increased, happiness decreased slightly.");
    }
    static void DisplayStatus()
    {
        Console.WriteLine($"\nPet Status -Hunger: {hunger}/10, Happiness: {happiness}/10, Health: {health}/10");
    }
}
    

    

