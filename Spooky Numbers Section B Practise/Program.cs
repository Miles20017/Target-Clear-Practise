using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spooky_Numbers_Section_B_Practise
{
    internal class Program
    {
        static bool CheckDigits(int A, int B, int Target)
        {
            List<char> digits = new List<char>();

            for (int i = 0; i < A.ToString().Length; i++)
            {
                digits.Add(A.ToString()[i]);
            }
            for (int i = 0; i < B.ToString().Length; i++)
            {
                digits.Add(B.ToString()[i]);
            }
            for (int i = 0; i < Target.ToString().Length; i++)
            {
                digits.Remove(Target.ToString()[i]);
            }

            if (digits.Count() == 0) return true;
            return false;
        }

        static (int,int) Spooky(int UserInput)
        {
            for (int i = 1; i < UserInput; i++)
            {
                for (int j = 1; j < UserInput; j++)
                {
                    if (i * j == UserInput)
                    {
                        if (CheckDigits(i, j, UserInput) == true) return (i,j);
                    }
                }
            }

            return (0,0);
        }

        static void Main(string[] args)
        {
            int UserInput = 0;
            while (UserInput <= 0)
            {
                Console.WriteLine("Enter A Number: ");
                UserInput = int.Parse(Console.ReadLine());
            }

            (int, int) Factors = Spooky(UserInput);
            int A = Factors.Item1;
            int B = Factors.Item2;

            if (A!=0 && B!=0) Console.WriteLine($"{UserInput} is a spooky number ({A} * {B})");
            else Console.WriteLine($"{UserInput} is not a spooky number");

            Console.ReadKey();
        }
    }
}
