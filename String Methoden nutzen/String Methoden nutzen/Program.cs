namespace String_Methoden_nutzen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte geben Sie Ihre Email ein: ");
			string email = Console.ReadLine();

			do
			{
				

				// eger @ eksikse
				if (!email.Contains("@"))
				{
					Console.WriteLine("Es gibt kein @ Zeichen!");
					continue;
				}
				// eger kullanici adi eksikse
				if (email.IndexOf("@") == 0)
				{
					Console.WriteLine("Es gibt kein Benutzername!");
				continue;
				}
				//her domain eksikse
				if (email.IndexOf("@") == email.Length - 1)
				{
					Console.WriteLine("Es gibt kein Domain!");
					continue;
				}
				// eger domain uzantisi eksikse
				if (!email.Contains(".com"))
				{
					Console.WriteLine("Domäne nicht korrekt");
					continue;
				}
				

			} while (email != "Email ist korrekt!");

			
			Console.ReadKey();

		}
	}
}
