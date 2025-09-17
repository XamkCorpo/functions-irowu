using System;

namespace FunctionAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = KysyNimi();
            int age = KysyIkä();

            TulostaNimiIkä(name, age);
            bool isAdult = OnkoTäysiIkäinen(age);

            // Example usage of VertaaNimi
            VertaaNimi(name, "Matti");
        }

        // Ask for name and ensure it is not empty
        static string KysyNimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }

        // Ask for age and ensure it is a positive integer
        static int KysyIkä()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }

        // Print name and age
        static void TulostaNimiIkä(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        // Check if the user is an adult
        static bool OnkoTäysiIkäinen(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
                return true;
            }
            else
            {
                Console.WriteLine("You are not an adult.");
                return false;
            }
        }

        // Compare the name to another string (e.g., "Matti")
        static void VertaaNimi(string name, string compareName)
        {
            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
    }
}
