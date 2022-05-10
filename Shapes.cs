using System;

namespace AlanHesaplama
{
    class Shapes
    {
        public static void Circle()
        {
            Console.WriteLine("\nYarıçap uzunluğunu giriniz:");
            float radius = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\nDairenin neyini hesaplamak istediğinizi seçiniz (pi sayısı 3 alınacaktır.):");
            Console.WriteLine("Çevre (1)");
            Console.WriteLine("Alan (2)\n");

            InputProgressID:

            int inputProgressID = ConsoleManager.GetCorrectInputInt();

            switch (inputProgressID)
            {
                case 1 :
                    Console.WriteLine("\nÇevre; " + 6 * radius);
                    break;

                case 2 :
                    Console.WriteLine("\nAlan; " + 3 * Math.Pow(radius, 2));
                    break;

                default :
                    Console.WriteLine("\nSayınız 1 ve 2 sayıları dışındaki bir değere sahip olamaz! Tekrar sayı giriniz:");
                    goto InputProgressID;
            }
        }

        public static void Triangle()
        {
            Console.WriteLine("\n1. kenar uzunluğunu giriniz:");
            float firstEdgeLength = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\n2. kenar uzunluğunu giriniz:");
            float SecondEdgeLength = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\n3. kenar uzunluğunu giriniz:");
            float ThirdEdgeLength = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\n1. kenara ait yüksekliği giriniz");
            float height = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\nÜçgenin neyini hesaplamak istediğinizi seçiniz:");
            Console.WriteLine("Çevre (1)");
            Console.WriteLine("Alan (2)\n");

            InputProgressID:

            int inputProgressID = ConsoleManager.GetCorrectInputInt();

            switch (inputProgressID)
            {
                case 1 :
                    Console.WriteLine("\nÇevre; " + (firstEdgeLength + SecondEdgeLength + ThirdEdgeLength));
                    break;

                case 2 :
                    Console.WriteLine("\nAlan; " + firstEdgeLength * height / 2);
                    break;

                default :
                    Console.WriteLine("\nSayınız 1 ve 2 sayıları dışındaki bir değere sahip olamaz! Tekrar sayı giriniz:");
                    goto InputProgressID;
            }
        }

        public static void Square()
        {
            Console.WriteLine("\nBir kenar uzunluğu giriniz:");
            float edge = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\nKarenin neyini hesaplamak istediğinizi seçiniz:");
            Console.WriteLine("Çevre (1)");
            Console.WriteLine("Alan (2)\n");

            InputProgressID:

            int inputProgressID = ConsoleManager.GetCorrectInputInt();

            switch (inputProgressID)
            {
                case 1 :
                    Console.WriteLine("\nÇevre; " + edge * 4);
                    break;

                case 2 :
                    Console.WriteLine("\nAlan; " + Math.Pow(edge, 2));
                    break;

                default :
                    Console.WriteLine("\nSayınız 1 ve 2 sayıları dışındaki bir değere sahip olamaz! Tekrar sayı giriniz:");
                    goto InputProgressID;
            }
        }

        public static void Rectangle()
        {
            Console.WriteLine("\nUzun kenarın uzunluğunu giriniz:");
            float longEdge = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\nKısa kenarın uzunluğunu giriniz:");
            float shortEdge = ConsoleManager.GetCorrectInputFloat();

            Console.WriteLine("\nDikdörtgenin neyini hesaplamak istediğinizi seçiniz:");
            Console.WriteLine("Çevre (1)");
            Console.WriteLine("Alan (2)\n");

            InputProgressID:

            int inputProgressID = ConsoleManager.GetCorrectInputInt();

            switch (inputProgressID)
            {
                case 1 :
                    Console.WriteLine("\nÇevre; " + ((longEdge + shortEdge) * 2));
                    break;

                case 2 :
                    Console.WriteLine("\nAlan; " + longEdge * shortEdge);
                    break;

                default :
                    Console.WriteLine("\nSayınız 1 ve 2 sayıları dışındaki bir değere sahip olamaz! Tekrar sayı giriniz:");
                    goto InputProgressID;
            }
        }
    }
}