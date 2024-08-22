namespace Kontrollstrukturen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte geben Sie einen Satz ein!");
			string input = Console.ReadLine();
			// Kelimeleri boşluklardan ayırarak bir diziye atıyoruz.
			string[] words = input.Split(' ');
			// Kelime sayısını alıyoruz.
			int wordCount = words.Length;
			Console.WriteLine($"Position längstes Word :{wordCount}");
			// En uzun kelimeyi buluyoruz.
			string longestWord = "";
			foreach (string word in words)
			{
				// Eğer kelimenin uzunluğu en uzun kelimenin uzunluğundan büyükse, en uzun kelimeyi güncelliyoruz.
				if (word.Length > longestWord.Length)
				{
					longestWord = word;
				}
			}
			Console.WriteLine($"Länge des längsten Wortes: {longestWord.Length}");
			Console.WriteLine($"Längstes Wort: {longestWord}");
		}
	}
}
