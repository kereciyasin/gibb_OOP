namespace Anwenden_von_nicht_statischen
{
	internal class Program
	{
		// HelloSay methodunu olustur
		public static void HelloSay(string name, string language)
		{

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

	

		}
	}
}
