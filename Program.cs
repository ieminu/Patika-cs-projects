using System;
using System.Collections;
using System.Collections.Generic;

namespace Algoritma
{
    class MainClass
    {
        static void Main(string[] args)
        {
            RunItAgain:

            Console.WriteLine("\nKendisinden bir karakter çıkartılcak ifadeyi ardından da ',' işaretini girdikten sonra dizin giriniz:");
            ArrayList inputs = ConsoleManager.InputString();

            string output = inputs[0].ToString();

            try
            {
                output = inputs[0].ToString().Remove(int.Parse(inputs[1].ToString()), 1);
            }
            catch
            {}

            finally
            {
                Console.WriteLine("\nÇıktı; " + output);
            }

            Console.WriteLine("\nYeniden denemek için 'y' giriniz:");
            string inputKey = Console.ReadLine();

            if (inputKey == "y")
            {
                goto RunItAgain;
            }
        }
    }
}