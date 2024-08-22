namespace Kontrollstrukturen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte geben Sie einen Satz ein!");
			string input = Console.ReadLine();
			string[] words = input.Split(' ');
			int wordCount = words.Length;
			Console.WriteLine($"Position längstes Word :{wordCount}");

			string longestWord = "";
			foreach (string word in words)
			{
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
