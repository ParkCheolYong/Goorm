using System;
namespace goorm
{
	class Program
	{
		static void Main(string[] args)
		{
      string input = Console.ReadLine();
			
      int n = int.Parse(input.Split(' ')[0]);
      int k = int.Parse(input.Split(' ')[1]);			
			   
			 n = n - k;
       n = (int)Math.Ceiling(n / (k - 1.0)) + 1;
			
			
			Console.WriteLine(n.ToString());
		}
	}
}