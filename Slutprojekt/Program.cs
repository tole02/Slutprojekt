using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Information om vad spelet är och hur det ska spelas
            Console.WriteLine("I detta spelet spelar du som en kung/drottning som ska styra över ett medeltida kungadöme.");
            Console.WriteLine("Du måste använda dina resurser för att se till att dina undersåtar och deras städer och byar är glada.");
            Console.WriteLine("Du gör detta genom att fördela dina skatter och bygga olika saker i städerna, t.ex kyrkor.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Ännu fler instruktioner
            Console.WriteLine("De städerna du styr över kommer i tre olika storlekar med olika förutsättningar.");
            Console.WriteLine("1.By 2.Stad 3.Storstad.");
            Console.WriteLine("En by har den minsta populationen och därmed behöver minst mängd pengar för att fungera, men du får även mindre i skatt från en by.");
            Console.WriteLine("En stad har större befolkning och större behov samt skatter, medans storstad har mest av allting.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Här instansieras varje klass
            Village stad1 = new Village();

            Towns stad2 = new Towns();

            City stad3 = new City();
            //Klassernas namn blir hämtade med hjälp av metoden GetName
            string a = stad1.GetName();

            string b = stad2.GetName();

            string c = stad3.GetName();

            Console.WriteLine("Du styr över tre städer, " + a + " en by, " + b + " en stad, och " + c + " en storstad.");

            












            System.Console.WriteLine("Tryck på vilken knapp som helst...");
            Console.ReadLine();
        }
    }
}
