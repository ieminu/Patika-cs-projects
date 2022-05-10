using System;

namespace AlanHesaplama
{
    class ConsoleManager
    {
        public static int GetCorrectInputInt()
        {
            int number = 0;

            TryInput();

            void TryInput()
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                
                catch (NullReferenceException)
                {
                    Console.WriteLine("\nBoş değer giremezsiniz! Sayı giriniz:");
                    TryInput();
                }

                catch (FormatException)
                {
                    Console.WriteLine("\nSayı dışında bir değer giremezsiniz! Sayı giriniz:");
                    TryInput();
                }

                if (number > int.MaxValue)
                {
                    Console.WriteLine("\nSayı, {0} sayısından büyük olamaz! Tekrar sayı giriniz:", int.MaxValue);
                    TryInput();
                }

                if (number < int.MinValue)
                {
                    Console.WriteLine("\nSayı, {0} sayısından küçük olamaz! Tekrar sayı giriniz:", int.MinValue);
                    TryInput();
                }
            }

            return number;
        }

        public static float GetCorrectInputFloat()
        {
            float number = 0;

            TryInput();

            void TryInput()
            {
                try
                {
                    number = float.Parse(Console.ReadLine());
                }

                catch (NullReferenceException)
                {
                    Console.WriteLine("\nBoş değer giremezsiniz! Sayı giriniz:");
                    TryInput();
                }

                catch (FormatException)
                {
                    Console.WriteLine("\nSayı dışında bir değer giremezsiniz! Sayı giriniz:");
                    TryInput();
                }

                if (number > float.MaxValue)
                {
                    Console.WriteLine("\nSayı, {0} sayısından büyük olamaz! Tekrar sayı giriniz:", float.MaxValue);
                    TryInput();
                }

                if (number < float.MinValue)
                {
                    Console.WriteLine("\nSayı, {0} sayısından küçük olamaz! Tekrar sayı giriniz:", float.MinValue);
                    TryInput();
                }
            }

            return number;
        }
    }
}