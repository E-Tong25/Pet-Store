using System;
using System.Text.Json;

namespace PetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (int.Parse(userInput) == 1)
                {
                    Product.AddProduct();
                }
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");
              
                userInput = Console.ReadLine();

            }
        }
    }
}

