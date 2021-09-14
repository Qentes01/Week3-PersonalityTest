using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said");
            string Grade = Console.ReadLine();


            if (Grade == "5")
            {
                Console.WriteLine("Super");
            }
            else if (Grade == "4")
            {
                Console.WriteLine("Väga hea");
            }
            else if (Grade == "3")
            {
                Console.WriteLine("Hea");
            }
            else if (Grade == "2")
            {
                Console.WriteLine("Rahuldav.");
            }
            else if  (Grade == "1")
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Head päeva");
            }
        }
    }
}
