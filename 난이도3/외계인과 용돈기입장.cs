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
            int m = int.Parse(input.Split(' ')[1]);

            input = Console.ReadLine();
            string[] arrInput = input.Split(' ');
            List<int> listInput = new List<int>();
            listInput = arrInput.Select(x => int.Parse(x)).ToList();
			listInput.Insert(0, 0);

            long[] arrSum = new long[n + 1];
            for (int i = 1; i < arrSum.Length; i++)
            {
                arrSum[i] = arrSum[i - 1] + listInput[i];
            }
			
            List<int[]> listDate = new List<int[]>();
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine();

                listDate.Add(new int[2] { int.Parse(input.Split(' ')[0]), int.Parse(input.Split(' ')[1]) });
            }

            foreach (int[] i in listDate)
            {
                long sum = arrSum[i[1]] - arrSum[i[0] - 1];

                if (sum > 0)
                    Console.WriteLine("+" + sum.ToString());
                else
                    Console.WriteLine(sum.ToString());
            }
		}
	}
}