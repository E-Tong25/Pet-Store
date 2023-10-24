using System;
using System.Text.Json;

namespace PetStore
{
	public class DogLeash: Product
	{
		public int LengthInches { get; set; }
		public string Material { get; set; }

		public static void AddDogLeash()
		{
            var dogLeash = new DogLeash();
            Console.WriteLine("What is the name of the dog leash to be added?");
            dogLeash.Name = Console.ReadLine();
            Console.WriteLine("What is the price of " + dogLeash.Name + " ?");
            dogLeash.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the description of " + dogLeash.Name + " ?");
            dogLeash.Description = Console.ReadLine();
            Console.WriteLine("What is the quantity of " +dogLeash.Name+ " ?");
            dogLeash.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the length in inches for the product " + dogLeash.Name + " ?");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the material of " +dogLeash.Name+ " ?");
            dogLeash.Material = Console.ReadLine();
            Console.WriteLine(JsonSerializer.Serialize(dogLeash));
        }
	}
}

