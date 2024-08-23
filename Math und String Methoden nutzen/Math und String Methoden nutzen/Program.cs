using System.Security.Cryptography.X509Certificates;

namespace Math_und_String_Methoden_nutzen
{
	internal class Program
	{
		// bana bir method yaz sayinin karakökünü alacak
		static double BerechneWurzel(double zahl)
		{
			return Math.Sqrt(zahl);
		}

		static void Main(string[] args)
		{
			
			
			Console.WriteLine("Geben Sie eine Zahl ein: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Die Wurzel von " + num + " ist " + BerechneWurzel(num));
			Console.ReadLine();	
		}
	}
}
