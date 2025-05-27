using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_B_Warm_Up___Cleaner_Version
{
    internal class Program
    {
        static bool IsAVowel(char c)
        {
            //Checks If The Input Character Is A Vowel
            return "aeiou".Contains(c);
        }

        static void Main(string[] args)
        {
            //Get User Input
            Console.WriteLine("Enter A String: ");
            string UserInput = Console.ReadLine();

            //Extract All The Vowels Into a List
            List<char> VowelsAsTheyAppearInWord = new List<char>();
            for (int i = 0; i < UserInput.Length; i++)
            {
                char c = UserInput[i];
                if (IsAVowel(c)) VowelsAsTheyAppearInWord.Add(c);
            }

            //Reverse The List Of Extracted Vowels
            VowelsAsTheyAppearInWord.Reverse();

            //Reassemble The String With The Newly Ordered Vowels
            string Final = "";
            for (int i = 0; i < UserInput.Length; i++)
            {
                char c = UserInput[i];
                if (IsAVowel(c))
                {
                    Final += VowelsAsTheyAppearInWord[0];
                    VowelsAsTheyAppearInWord.RemoveAt(0);
                }
                else
                {
                    Final += c;
                }
            }

            //Output To User
            Console.WriteLine($"New String: {Final}");
            Console.ReadKey();
        }
    }
}
