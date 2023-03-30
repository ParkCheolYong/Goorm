using System;
using System.Collections.Generic;
using System.Linq;

namespace goorm
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int n = int.Parse(input.Split(' ')[0]);
			int k = int.Parse(input.Split(' ')[1]);

			List<string> wordList = new List<string>();

			for (int i = 0; i < n; i++)
			{
					wordList.Add(Console.ReadLine());
			}
			
			wordList = wordList.OrderBy(x => x.Length).ThenBy(x => x).ToList();
			
			Console.WriteLine(wordList[k - 1]);
		}
	}
}