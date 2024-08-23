namespace Anwenden_von_nicht_statischen
{
	internal class Program
	{
		// HelloSay methodunu olustur
		public static void HelloSay(string name, string language)
		{
			// Eger language Turkish ise
			if (language == "Turkish")
			{
				// Merhaba name yaz
				Console.WriteLine("Merhaba " + name);
			}
			// Eger language English ise
			else if (language == "English")
			{
				// Hello name yaz
				Console.WriteLine("Hello " + name);
			}
			// Eger language Arabic ise
			else if (language == "Arabic")
			{
				// Ahlan name yaz
				Console.WriteLine("Ahlan " + name);
			}
		}

		static void Main(string[] args)
		{
			// person clasini list ile kullanma
			List<Person> people = new List<Person>
			{
				new Person { Name = "Ahmet", Language = "Turkish" },
				new Person { Name = "John", Language = "English" },
				new Person { Name = "Ali", Language = "Arabic" }
			};

			// people listesindeki her bir kisinin adi ve dili icin HelloSay methodunu cagir	
			foreach (var person in people)
			{
				HelloSay(person.Name, person.Language);
			}



			// Bekle
			Console.ReadKey();


		}
	}
}
