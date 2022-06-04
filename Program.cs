using System;

namespace KarakterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram:

            Console.WriteLine("\nİçerisindeki kelimelerin ilk ve son harflerinin yerlerinin, ters çevirileceği bir ifade giriniz:\n");
            
            Input:
            
            string input = Console.ReadLine();
            
            // Equalize the number of spaces in 'spacesAsLengthOfInput' to input's length {
            string spacesAsLengthOfInput = "";
            for (int i = 0; i < input.Length; i++)
                spacesAsLengthOfInput += ' ';
            // }

            // Turn the long spaces into one space {
            for (string spaces = spacesAsLengthOfInput; spaces.Length > 1; spaces = spaces.Remove(0, 1))
            {
                CheckSpaces:

                if (input.Contains(spaces))
                {
                    input = input.Replace(spaces, " ");
                    goto CheckSpaces;
                }
            }
            // }

            try
            {
                if (input[0] == ' ')
                {
                    input = input.Remove(0, 1);
                }

                if (input[input.Length - 1] == ' ')
                {
                    input = input.Remove(input.Length - 1, 1);
                }
            }

            catch{}

            if (input.Length == 0)
            {
                Console.WriteLine("\nBoş değer giremezsiniz! Tekrar giriniz:\n");
                goto Input;
            }

            else
            {
                string[] words = input.Split(" ");
                string[] reversedWords = new string[words.Length];

                for (int i = 0; i < words.Length; i++)
                {
                    char firstCharcter = words[i][0];
                    reversedWords[i] = words[i].Length > 1 ? words[i][words[i].Length - 1] + words[i].Remove(words[i].Length - 1, 1).Remove(0, 1) + firstCharcter : words[i];
                }

                Console.Write("\nÇıktı;");
                foreach (string reversedWord in reversedWords)
                {
                    Console.Write(" ");
                    Console.Write(reversedWord);
                }
                Console.Write("\n");

                Console.WriteLine("\nYeniden denemek için 'y' giriniz:\n");
                string inputKey = Console.ReadLine();

                if (inputKey == "y")
                {
                    goto RunProgram;
                }
            }
        }
    }
}