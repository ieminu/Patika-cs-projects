using System;
using System.Collections;
using System.Collections.Generic;

namespace KarakterTerstenYazdirma
{
    class ConsoleManager
    {
        public static string CorrectStringInput()
        {
            Input:

            string input = Console.ReadLine();

            RemoveFirstSpace:

            if (input[0] == ' ')
            {
                if (input.Length == 1)
                {
                    Console.WriteLine("En az bir harf girmeniz gerekiyor! Yeniden deneyiniz:");
                    goto Input;
                }

                input = input.Remove(0, 1);
                goto RemoveFirstSpace;
            }

            RemoveLastSpace:

            if (input[input.Length - 1] == ' ')
            {
                input = input.Remove(input.Length - 1, 1);
                goto RemoveLastSpace;
            }

            // equalize the number of spaces in "spaces" variable to input's length {
            string maxSpacesInInput = "";
            for (int i = 0; i < input.Length; i++)
                maxSpacesInInput += ' ';
            // }

            for (string spaces = maxSpacesInInput; spaces.Length > 1; spaces = spaces.Remove(0, 1))
            {
                Check:

                if (input.Contains(spaces))
                {
                    input = input.Replace(spaces, " ");
                    goto Check;
                }
            }

            return input;
        }
    }
}