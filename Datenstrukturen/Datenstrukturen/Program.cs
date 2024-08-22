namespace Datenstrukturen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Willkommen beim Lotto-Simulator!");	
			int[] benutzerTipps = new int[6];
			int[] gezogeneZahlen = new int[6];
			
			Random zufall = new Random();

			// Benutzer-Tipps abfragen
			for (int i = 0; i < benutzerTipps.Length; i++)
			{
				Console.Write($"Tipp {i + 1}: ");
				benutzerTipps[i] = int.Parse(Console.ReadLine());
			}

			// Zufällige Zahlen ziehen
			for (int i = 0; i < gezogeneZahlen.Length; i++)
			{
				gezogeneZahlen[i] = zufall.Next(1, 46); // Zahlen zwischen 1 und 45 generieren
			}

			Console.WriteLine("\nEs wurden folgende Zahlen gezogen:");
			foreach (var zahl in gezogeneZahlen)
			{
				Console.Write(zahl + " ");
			}

			// Treffer überprüfen
			int trefferAnzahl = 0;
			foreach (var tipp in benutzerTipps)
			{
				if (gezogeneZahlen.Contains(tipp))
				{
					Console.WriteLine($"\nTreffer: {tipp}");
					trefferAnzahl++;
				}
			}

			Console.WriteLine($"\nSie haben {trefferAnzahl} Treffer erzielt.");

		}
	}
}
