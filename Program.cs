using System;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram:

            Console.WriteLine("\nÜzerinde işlem yapacağınız şekli seçiniz:");
            Console.WriteLine("Daire (1)");
            Console.WriteLine("Üçgen (2)");
            Console.WriteLine("Kare (3)");
            Console.WriteLine("Dikdörtgen (4)\n");

            InputShapeID:

            int inputShapeID = ConsoleManager.GetCorrectInputInt();

            switch (inputShapeID)
            {
                case 1 :
                    Shapes.Circle();
                    break;
                    
                case 2 :
                    Shapes.Triangle();
                    break;
                    
                case 3 :
                    Shapes.Square();
                    break;
                    
                case 4 :
                    Shapes.Rectangle();
                    break;

                default :
                    Console.WriteLine("\nSayınız 1, 2, 3 ve 4 sayıları dışındaki bir değere sahip olamaz! Tekrar sayı giriniz:");
                    goto InputShapeID;
            }

            Console.WriteLine("\nYeniden denemek için 'y' giriniz:");
            string inputKey = Console.ReadLine();

            if (inputKey == "y")
            {
                goto RunProgram;
            }
        }
    }
}