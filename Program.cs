using System;

namespace IntegerIkililerinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram:

            Console.WriteLine("\n67'den küçük olanların sadece 67 ile olan mutlak farklarının toplanacağı, 67'den büyük olanların ise 67 ile olan mutlak farklarının kareleri alınıp toplanacağı sayıları giriniz:");
            
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
                Console.WriteLine("\n{0} sayısından büyük veya {1} sayısından küçük bir sayı giremezsiniz! Tekrar giriniz:", Math.Sqrt(float.MaxValue + 67), float.MinValue + 67);
                goto Input;
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("\nBoş değer giremezsiniz! Tekrar giriniz:");
                goto Input;
            }

            foreach (float number in numbers)
            {
                if (number < float.MinValue + 67)
                {
                    Console.WriteLine("\n{0} sayısından küçük bir sayı giremezsiniz! Tekrar giriniz:", float.MinValue + 67);
                    goto Input;
                }

                if (number > Math.Sqrt(float.MaxValue + 67))
                {
                    Console.WriteLine("\n{0} sayısından büyük bir sayı giremezsiniz! Tekrar giriniz:", Math.Sqrt(float.MaxValue + 67));
                    goto Input;
                }
            }

            float firstOutput = 0;
            float secondOutput = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 67)
                {
                    firstOutput += 67 - numbers[i];
                }

                if (numbers[i] > 67)
                {
                    secondOutput += (float)Math.Pow(numbers[i] - 67, 2);
                }
            }

            Console.WriteLine("\n67'den küçük olanların, 67 ile olan mutlak farklarının toplamı; " + firstOutput);
            Console.WriteLine("\n67'den büyük olanların, 67 ile olan mutlak farklarının karesinin toplamı; " + secondOutput);

            Console.WriteLine("\nYeniden denemek için 'y' giriniz:");
            string inputKey = Console.ReadLine();

            if (inputKey == "y")
            {
                goto RunProgram;
            }
        }
    }
}