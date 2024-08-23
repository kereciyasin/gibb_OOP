namespace String_Methoden_nutzen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte geben Sie Ihre Email ein: ");
			string email = Console.ReadLine();

			// eger @ eksikse
			if (!email.Contains("@"))
			{
				Console.WriteLine("Es gibt kein @ Zeichen!");
				return;
			}
			// eger kullanici adi eksikse
			if (email.IndexOf("@") == 0)
			{
				Console.WriteLine("Es gibt kein Benutzername!");
				return;
			}
			//her domain eksikse
			if (email.IndexOf("@") == email.Length - 1)
			{
				Console.WriteLine("Es gibt kein Domain!");
				return;
			}
			// eger domain uzantisi eksikse
			if (!email.Contains(".com"))
			{
				Console.WriteLine("Domäne nicht korrekt");
				return;
			}
			Console.WriteLine("Email ist korrekt!");

		}
	}
}
