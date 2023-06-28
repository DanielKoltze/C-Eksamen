using System;
using System.Linq;
namespace eksamen
{
	public class Dis6
	{
		public static void Dis6Main()
		{

			//vise et eksempel hvordan det ville gøres i plain c# og så ved at bruge linq methods
			var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
			/*
			var filtedList = new List<int>();

			foreach(int number in list)
			{
				if(number >= 5)
				{
					filtedList.Add(number);
				}
			}

			foreach(int number in filtedList)
			{
				Console.WriteLine(number);
			}
			*/

			var filteredList = list.Where(number => number >= 5);

            foreach (int number in filteredList)
            {
                Console.WriteLine(number);
            }


			//forklar sum og hvordan man bille gøre det uden
			var sum = list.Sum();

			var sum2 = 0;

			foreach(int number in list)
			{
				sum2 += number;
			}

			//forklar Select og hvordan man ville gøre det uden

			var squarednumbers = list.Select(number => number * number);

			var squaredNumbersAbove5 = list.Where(number => number >= 5).Select(number => number * number).OrderDescending();

            foreach (int number in squaredNumbersAbove5)
            {
                Console.WriteLine(number);
            }


			//gå videre til query syntax og hvorfor det er smart og hvad man bruger det til

			int[] numbers = { 1, 2, 3, 4 };
            var evenNumbers = from n in numbers
							  where n % 2 == 0
							  select n;

			var listAbove5 = from n in numbers
                             where n >= 5
							 select n;

			// extension methods
			Console.WriteLine("word".Reverse());






        }
    }
}

public static class ReverseExtension
{
	public static string Reverse(this string input)
	{
		var inputToChar = input.ToCharArray();
		Array.Reverse(inputToChar);
		return new string(inputToChar);
	}

}
