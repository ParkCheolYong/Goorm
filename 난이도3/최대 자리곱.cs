using System;
using System.Linq;

namespace goorm
{
	class Program
	{
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                Console.WriteLine(input);
                return;
            }

            int[] arrNum = new int[input.Length];

            int answer = 1;

            for (int i = 0; i < input.Length; i++)
            {
                answer *= int.Parse(input[i].ToString());
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (j < i)
                    {
                        arrNum[j] = int.Parse(input[j].ToString());
                    }
                    else if (j == i)
                    {
                        string s = (int.Parse(input[j].ToString()) - 1).ToString();
                        int num = int.Parse(s == "0" ? "1" : s);

                        if (num > 0)
                        {
                            arrNum[j] = num;
                        }
                        else
                        {
                            arrNum[j - 1] = arrNum[j - 1] - 1;
                        }
                    }
                    else
                    {
                        arrNum[j] = 9;
                    }
                }

                answer = Math.Max(answer, arrNum.Aggregate((x, y) => x * y));
            }

            Console.WriteLine(answer);
        }
    }
}