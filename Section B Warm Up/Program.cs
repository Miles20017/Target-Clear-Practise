using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_B_Warm_Up
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string: ");
            string UserInput = Console.ReadLine();

            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            List<char> VowelsInSentace = new List<char>();

            for (int i = 0; i < UserInput.Length; i++)
            {
                if (Vowels.Contains(UserInput[i])) VowelsInSentace.Add(UserInput[i]);
            }

            int N = VowelsInSentace.Count;

            for (int i = 0; i < VowelsInSentace.Count/2; i++)
            {
                char temp = VowelsInSentace[N - i-1];
                VowelsInSentace[N - i-1] = VowelsInSentace[i];
                VowelsInSentace[i] = temp;
            }

            List<char> NewString = UserInput.ToList();

            int VowelCount = 0;
            for(int i=0;i < NewString.Count; i++)
            {
                if (Vowels.Contains(NewString[i]))
                {
                    NewString[i] = VowelsInSentace[VowelCount];
                    VowelCount++;
                }
            }

            string Final = "";
            for(int i = 0; i < NewString.Count; i++)
            {
                Final+= NewString[i];
            }

            Console.WriteLine($"New string: {Final}");

            Console.ReadKey();
        }
    }
}
