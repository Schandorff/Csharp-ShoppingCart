using System;
using System.Collections.Generic;

namespace ShoppingCart
{
	class MainClass
	{

		public static void Main(string[] args)
		{

			List<string> cart = new List<string>();
			List<string> cartPrice = new List<string>();
			Dictionary<string, string> ordbog = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

			ordbog.Add("Banana", "one banana");
			ordbog.Add("Apple", "one apple");
			ordbog.Add("Pear", "one pear");
			ordbog.Add("Orange", "one orange");
			ordbog.Add("Watermelon", "one watermelon");
			Console.WriteLine("Our fruits:");
			foreach (var fruit in ordbog)
			{
				Console.WriteLine(fruit.Key);
			}

			Console.WriteLine("Choose fruit to add to cart");

			int count = 0;
			string input = "y";
			bool x = false;
			while (x == false)
			{



				string searchTerm = Console.ReadLine();
				if (ordbog.ContainsKey(searchTerm.ToLower()))
				{
					string value = ordbog[searchTerm];
					cart.Add(value);
					Console.WriteLine(value + " Added to your basket");

				}



				else
				{
					Console.WriteLine("no such" + searchTerm + "in directory");
				}


				count++;
				Console.WriteLine("You picked " + count + " fruits so far");
				Console.WriteLine("Would you like to add more? (y/n)");
				input = Console.ReadLine();

				if (input == "y")
				{
					Console.WriteLine("Choose another fruit to add");
				}
				else if (input == "n")
				{
					x = true;
				}

			}
			Console.WriteLine("The final inventory of your cart:");
			foreach (var fruit in cart)
			{
				Console.WriteLine(fruit);
			}

		}
	}
}