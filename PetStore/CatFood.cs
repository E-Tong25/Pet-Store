using System;
using System.Text.Json;

namespace PetStore
{
	public class CatFood: Product
	{
		public double WeightPounds { get; set; }
		public bool KittenFood { get; set; }

        public static void AddCatFood()
		{
            var catFood = new CatFood();
            Console.WriteLine("What is the name of the cat food to be added?");
            catFood.Name = Console.ReadLine();
            Console.WriteLine("What is the price of " + catFood.Name + " ?");
            catFood.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("True or False: " + catFood.Name + " is for kittens?");
            catFood.KittenFood = bool.Parse(Console.ReadLine());
            Console.WriteLine("What is the description of " + catFood.Name+" ?");
            catFood.Description = Console.ReadLine();
            Console.WriteLine("What is the weight of " +catFood.Name+ " in pounds?");
            catFood.WeightPounds = double.Parse(Console.ReadLine());
            Console.WriteLine("What is  quantity of " + catFood.Name + " ?");
            catFood.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine(JsonSerializer.Serialize(catFood));
         
        }
	}
}

