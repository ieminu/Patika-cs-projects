using System;
using System.Collections;
using System.Collections.Generic;

namespace DaireCizme
{
    class MainClass
    {
        int radius;

        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();

            DrawAgain:

            Console.WriteLine();
            Console.WriteLine("Çizilcek dairenin yarıçapını giriniz:");
            mainClass.radius = ConsoleManager.InputInt();

            Console.WriteLine();
            mainClass.DrawCircle();

            Console.WriteLine();
            Console.WriteLine("Yeni bir daire çizmek için 'y' yazınız: ");
            string inputString = Console.ReadLine();

            if (inputString == "y")
            {
                goto DrawAgain;
            }
        }

        void DrawCircle()
        {
            string symbolToDrawWith = "o ";

            bool isRadiusNot1or2 = radius != 1 && radius != 2 == true ? true : false;

            if (isRadiusNot1or2)
            {
                // satır başı boşluk sayısı;
                int spaceNumberOfLineBeggining = radius % 2 == 1 ? radius + 1 : radius + 2;//6
                // kareler arası boşluk sayısı;
                int spaceNumberOfBetweenSquares = radius % 2 == 1 ? (radius - 1) * 2 : (radius - 2) * 2;//8

                // 1. satır {
                Console.WriteLine();

                for (int i = 0; i < spaceNumberOfLineBeggining; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < (radius % 2 == 1 ? radius - 1 : radius - 2); i++)
                {
                    Console.Write(symbolToDrawWith);
                }
                // }

                // 1. satır ile ortanca satırlar arasında kalan satırlar {
                for (int i = 0; i < (radius % 2 == 1 ? (radius - 1) / 2 : radius / 2); i++)
                {
                    Console.WriteLine();

                    spaceNumberOfLineBeggining -= 2;

                    for (int j = 0; j < spaceNumberOfLineBeggining; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbolToDrawWith);

                    for (int l = 0; l < (spaceNumberOfBetweenSquares); l++)
                    {
                        Console.Write(" ");
                    }

                    spaceNumberOfBetweenSquares += 4;

                    Console.Write(symbolToDrawWith);
                }
                // }

                // ortanca satırlar {
                for (int i = 0; i < (radius % 2 == 1 ? radius - 1 : radius - 2); i++)
                {
                    Console.WriteLine();

                    Console.Write(symbolToDrawWith);

                    for (int j = 0; j < spaceNumberOfBetweenSquares; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbolToDrawWith);
                }
                // }

                // ortanca satırlar ile sonuncu satır arasında kalan satırlar {
                for (int i = 0; i < (radius % 2 == 1 ? (radius - 1) / 2 : radius / 2); i++)
                {
                    Console.WriteLine();

                    spaceNumberOfBetweenSquares -= 4;

                    for (int j = 0; j < spaceNumberOfLineBeggining; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbolToDrawWith);

                    for (int l = 0; l < spaceNumberOfBetweenSquares; l++)
                    {
                        Console.Write(" ");
                    }

                    spaceNumberOfLineBeggining += 2;

                    Console.Write(symbolToDrawWith);
                }
                // }

                // sonuncu satır {
                Console.WriteLine();

                for (int i = 0; i < spaceNumberOfLineBeggining; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < (radius % 2 == 1 ? radius - 1 : radius - 2); i++)
                {
                  Console.Write(symbolToDrawWith);
                }
                // }

                Console.WriteLine();
            }

            else
            {
                // istisnalar {
                switch (radius)
                {
                  case 1 :
                      Console.WriteLine(" oo");
                      Console.WriteLine("o  o"); 
                      Console.WriteLine(" oo");
                      break;

                  case 2 :
                      Console.WriteLine(" ooo");
                      Console.WriteLine("o   o");
                      Console.WriteLine("o   o");
                      Console.WriteLine(" ooo");
                      break;
                }
                // }
            }
        }
    }
}