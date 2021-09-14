using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajat sisestades tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", onsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisteab midagi muud, konsool kuvab "oled ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string Color = Console.ReadLine().ToLower();

            switch (Color)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {Color} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
