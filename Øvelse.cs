using System;
namespace eksamen
{
	public class Øvelse
	{
		public static void ØvelseMain()
		{
			int tal = 5;
			string name = "daniel";

			var tal2 = 2;

			double tal3 = tal2;


			int tal4 = (int)tal3;

			//Type type = typeof(tal);

			//string, int, char

			int? navn = null;


			// if(person != null && person.Name != null)

			// if(person?.Name != null)



			string name2 = null;

			string name3 = name2 ?? "unknown";


			string sequence = $"hej jeg hedder {name3:3}";
		}
	}
}

