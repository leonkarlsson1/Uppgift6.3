using System;
namespace Uppgift_6_3
{
    class program
    {
        static void Main(string[]args)
        {
            string användarensVal = "";
            while(användarensVal!="3")
            {
                SkrivMeny();
                användarensVal=Console.ReadLine();
                Console.WriteLine();

                switch(användarensVal)
                {
                    case "1":
                        Menyaddera();
                        break;

                    case "2":
                        Menystörsta();
                        break;
                    case "3":
                        break;
                }
                Console.WriteLine();
            }
        }
        static void SkrivMeny()
        {
            Console.WriteLine("Välj ett av dessa alternativen!");
            Console.WriteLine("1.Addera tre tal");
            Console.WriteLine("2.Största talet av två tal");
            Console.WriteLine("3.Avsluta programmet");
        }
        static void Menyaddera()
        {
            Console.WriteLine("skriv in tre tal");
            double tal1=double.Parse(Console.ReadLine());
            double tal2=double.Parse(Console.ReadLine());
            double tal3=double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1}+{tal2}+{tal3}={tal1 + tal2 + tal3}");
        }
        static int Störst(int tal1, int tal2)
        {


            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }

        }
        static void Menystörsta()
        {
            Console.WriteLine("Skriv in två tal);
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Det Största tal är:{Störst(tal1, tal2)}");
        }
    }
}
