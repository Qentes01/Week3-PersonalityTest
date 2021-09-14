using System;

namespace PersonalityTest
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

            Console.WriteLine("Mis on sinu lemmikvärv?");
            string Color = Console.ReadLine();


            if (Color == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if (Color == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }

            else if (Color == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine("Oled ükssarvik");
            }



        }
    }
}
