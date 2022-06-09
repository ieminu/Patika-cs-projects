using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram:

            Console.WriteLine("\nİçerisindeki kelimelerin her birinde; yan yana iki sessiz harf varsa true, yoksa false yazılcak ifadeyi giriniz:\n");
            
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

            char[] consonants = {'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z', 'q', 'w', 'x'};

            if (input.Length == 0)
            {
                Console.WriteLine("\nBoş değer giremezsiniz! Tekrar giriniz:\n");
                goto Input;
            }

            string[] words = input.Split(" ");

            Console.Write("\nÇıktı;");
            
            foreach (string word in words)
            {
                Console.Write(" ");

                bool isFirstConsonantFounded = false;
                bool isTrue = false;
                int letterCounter = 0;

                foreach (char letter in word.ToLower())
                {
                    foreach (char consonant in consonants)
                    {
                        if (letter == consonant)
                        {
                            if (isFirstConsonantFounded)
                            {
                                isTrue = true;
                            }

                            else
                            {
                                isFirstConsonantFounded = true;
                            }

                            break;
                        }
                    }
                    
                    if (isTrue)
                    {
                        break;
                    }

                    if (isFirstConsonantFounded)
                    {
                        letterCounter++;

                        if (letterCounter >= 2)
                        {
                            isFirstConsonantFounded = false;
                            letterCounter = 0;
                        }
                    }
                }

                Console.Write(isTrue);
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