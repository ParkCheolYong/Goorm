using System;
namespace goorm
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			input = Console.ReadLine();
			
			long n = long.Parse(input);
			
			long output = 0;
			
			output = (n * (n + 1)) / 2 % 1000000007;
			
			output = (output * output) % 1000000007;
			
			Console.WriteLine(output.ToString());
		}
	}
}