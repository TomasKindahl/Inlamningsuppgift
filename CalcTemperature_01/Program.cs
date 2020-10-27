using System;

namespace CalcTemperature_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawMenu();
            Console.ReadKey();
        }
        static void DrawMenu()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Välj bland alteranativen nedan!");
            Console.WriteLine("1 konverterar från C till F.\n 2 Konverterar Från F till C. \n 3 Konverterar från C till K. \n 4 Konverterar från K till F. ");
            Console.WriteLine("********************************");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            switch (choice)
            {
                case 1:
                    Menu1();
                    break;
                case 2:
                    //Double metod???????
                    Menu2();
                    break;
                default:
                    Console.WriteLine("FEL");
                    break;
            }
        }
        static void Menu1()
        {
            Console.Write("Skriv temperaturen!!!!Endast siffror!!!");
            string userInput = Console.ReadLine();
            double a = double.Parse(userInput);
            //Placeholder!!!!!!!
            double calcCtoF = a * a;

            Console.Write($"Temperaturen i Fahrenheit är = {calcCtoF} grader !");
        }
        static double Menu2()
        {
            Console.Write("Skriv temperaturen!!!!Endast siffror!!!");
            string userInput = Console.ReadLine();
            double a = double.Parse(userInput);
            //Placeholder!!!!!!!
            return a * 2;
        }
        static double Menu3(double a)
        {
            //Placeholder!!!!!!!
            return a;
        }
        static double Menu4(double a)
        {
            //Placeholder!!!!!!!
            return a;
        }

    }
}