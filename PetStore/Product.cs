using System;
namespace PetStore
{
	public class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string Description { get; set; }

        public static void AddProduct()
		{

            Console.WriteLine("Please type 'cat food' to add a cat food product.");
            Console.WriteLine("Please type 'dog leash' to add a dog leash product.");

            string productInput = Console.ReadLine();

            productInput = productInput.ToLower();

            if (productInput == "cat food")
            {
                CatFood.AddCatFood();
            }
            if (productInput == "dog leash")
            {
                DogLeash.AddDogLeash();
            }
        }

	}
}

