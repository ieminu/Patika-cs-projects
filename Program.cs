using System;
using System.Collections;
using System.Collections.Generic;

namespace KarakterTerstenYazdirma
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Run:

            Console.WriteLine("\nTersten yazdırılacak kelimeleri aralarında boşluk bırakarak giriniz:");
            string input = ConsoleManager.CorrectStringInput();

            string[] words = input.Contains(" ") == true ? input.Split(" ") : input.Split("");

            // reverse the "words" array elements {
                for (int i = 0; i < words.Length; i++)
                {
                    string reversedWord = new string(words[i].Reverse().ToArray());
                    words[i] = reversedWord;
                }
            // }

            // print the "words" array elements {
                Console.WriteLine();
                foreach (string word in words)
                    Console.Write(word + " ");
                Console.Write("\n");
            // }

            Console.WriteLine("\nYeniden çalıştırmak için 'y' giriniz: ");
            string inputKey = Console.ReadLine();

            if (inputKey == "y")
            {
                goto Run;
            }
        }
    }
}