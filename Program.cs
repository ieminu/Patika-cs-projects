using System;

namespace IntegerIkililerinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram:

            Console.WriteLine("\nAralarında boşluk bırakarak çift sayıda pozitif sayı giriniz:");

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

            if (input.Length != 0 && input[0] == ' ')
            {
                input = input.Remove(0, 1);
            }

            if (input.Length != 0 && input[input.Length - 1] == ' ')
            {
                input = input.Remove(input.Length - 1, 1);
            }

            float[] numbers = new float[0];

            try
            {
                string[] stringNumbers = input.Split(" ");
                numbers = new float[stringNumbers.Length];

                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    numbers[i] = float.Parse(stringNumbers[i]);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("\nSayı dışında bir değer giremezsiniz! Tekrar giriniz:");
                goto Input;
            }

            catch (OverflowException)
            {
                Console.WriteLine("\n'{0}' sayısından büyük veya negatif bir sayı giremezsiniz! Tekrar giriniz:", Math.Sqrt(float.MaxValue) / 2);
                goto Input;
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("\nBoş değer giremezsiniz! Tekrar giriniz:");
                goto Input;
            }

            if (numbers.Length % 2 == 1)
            {
                Console.WriteLine("\nTek sayıda sayı giremezsiniz! Lütfen çift sayıda sayı giriniz:");
                goto Input;
            }

            foreach (float number in numbers)
            {
                if (number > Math.Sqrt(float.MaxValue) / 2)
                {
                    Console.WriteLine("\n'{0}' sayısından büyük bir sayı giremezsiniz! Tekrar giriniz:", Math.Sqrt(float.MaxValue) / 2);
                    goto Input;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i += 2)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    Console.Write(numbers[i] + numbers[i + 1] + " ");
                }

                else
                {
                    Console.Write(Math.Pow(numbers[i] + numbers[i + 1], 2) + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nYeniden denemek için 'y' giriniz:");
            string inputKey = Console.ReadLine();

            if (inputKey == "y")
            {
                goto RunProgram;
            }
        }
    }
}