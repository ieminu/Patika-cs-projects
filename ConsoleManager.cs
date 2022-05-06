using System;
using System.Collections;
using System.Collections.Generic;

namespace DaireCizme
{
    class ConsoleManager
    {
        public static int InputInt()
        {
            int number;

            TryConvertToInt();

            void TryConvertToInt()
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Geçersiz karakter! Lütfen bir sayı giriniz:");
                    TryConvertToInt();
                }

                if (number <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Geçersiz karakter! Lütfen pozitif bir sayı giriniz:");
                    TryConvertToInt();
                }

                if (number > 31)
                {
                    Console.WriteLine();
                    Console.WriteLine("Girebileceğiniz en büyük yarıçap değeri 31'dir! Bir sayı giriniz:");
                    TryConvertToInt();
                }
            }

            return number;
        }
    }
}