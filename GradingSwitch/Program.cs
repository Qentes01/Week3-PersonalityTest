using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");

            string Grade = Console.ReadLine();

            switch (Grade)
            {
                case "5":
                    Console.WriteLine("super");
                        break;
                case "4":
                    Console.WriteLine("vaga hea");
                        break;
                case "3":
                    Console.WriteLine("hea");
                    break;
                case "2":
                    Console.WriteLine("rahuldav");
                    break;
                case "1":
                    Console.WriteLine("puudulik");
                    break;
                default:
            }

        }
    }
}
