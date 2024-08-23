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
		
		}
	}
}
