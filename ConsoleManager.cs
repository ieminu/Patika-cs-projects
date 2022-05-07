using System;
using System.Collections;
using System.Collections.Generic;

namespace Algoritma
{
    class ConsoleManager
    {
        public static ArrayList InputString()
        {
            ArrayList fixedParameters = new ArrayList();

            TryInput();

            void TryInput()
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] parameters = input.Split(',');
                    fixedParameters = new ArrayList();

                    fixedParameters.Add(parameters[0]);
                    fixedParameters.Add(int.Parse(parameters[1]));
                }

                catch
                {
                    Console.WriteLine("Hatalı giriş! İfade giriniz:");
                    TryInput();
                }
            }

            return fixedParameters;
        }
    }
}