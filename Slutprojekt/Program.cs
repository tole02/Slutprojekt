using System;
using System.Threading;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här instansieras varje klass
            Village stad1 = new Village();

            Town stad2 = new Town();

            City stad3 = new City();

            Event1 e1 = new Event1();

            Event2 e2 = new Event2();
            //Instansernas namn blir hämtade med hjälp av metoden GetName
            string name1 = stad1.GetName();

            string name2 = stad2.GetName();

            string name3 = stad3.GetName();

            if(name1 == name2)
            {
                name1 = "Georgestown";
            }
            else if(name2 == name1)
            {
                name1 = "Georgestown";
            }
            else if(name2 == name3)
            {
                name2 = "Courtshire";
            }
            if(name3 == name2)
            {
                name2 = "Courtshire";
            }
            //Instansernas inkomster och behov blir insamlade med GetTaxes och GetNeeds
            int tax1 = stad1.GetTaxes();

            int tax2 = stad2.GetTaxes();

            int tax3 = stad3.GetTaxes();

            int needs1 = stad1.GetNeeds();

            int needs2 = stad2.GetNeeds();

            int needs3 = stad3.GetNeeds();
            //Instansernas gladhet blir hämtade av GetHappiness
            int happiness1 = stad1.GetHappiness();

            int happiness2 = stad2.GetHappiness();

            int happiness3 = stad3.GetHappiness();
            
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

            //Mer information till spelaren
            Console.WriteLine("Du styr över tre städer, " + name1 + " en by, " + name2 + " en stad, och " + name3 + " en storstad.");
            Console.WriteLine(name1 + " har en inkomst på " + tax1 + " guld och ett behov av " + needs1 + " guld.");
            Console.WriteLine(name2 + " har en inkomst på " + tax2 + " guld och ett behov av " + needs2 + " guld.");
            Console.WriteLine(name3 + " har en inkomst på " + tax3 + " guld och ett behov av " + needs3 + " guld.");
            Console.WriteLine("Varje stad börjar med en gladhet på 5, hamnar detta värde under noll så kommer de göra uppror och du förlorar.");
            Console.WriteLine("Så länge du kan möta deras behov kommer deras gladhet inte gå ner, och du kan få upp den genom att bygga saker.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Alla instansernas skatter och behov samlas i två ints
            int totalTaxes = tax1 + tax2 + tax3;

            int totalNeeds = needs1 + needs2 + needs3;
            //Spelaren får reda på hur mycket pengar den har och vad den första staden har för gladhet och behov, sedan får den bestämma hur mycket den ska betala staden
            Console.WriteLine("Du ska spela två månader (spelet blir för långt annars) och får göra olika val samtidigt som du hanterar dina städer.");
            Console.WriteLine("Du börjar med en inkomst på " + totalTaxes + " guld och betalar ut " + totalNeeds + " guld.");
            
            e1.WriteInfo(totalTaxes, stad1, stad2, stad3);

            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            
            e1.BuildHouse(stad1, stad2, stad3);

            //Gladheten samlas in igen då den kan ha blivit uppdaterad av att spelaren byggde i en av städerna
            int fourthHappiness1 = stad1.GetHappiness();
            int fourthHappiness2 = stad2.GetHappiness();
            int fourthHappiness3 = stad3.GetHappiness();
            //Skattkistan återfylls
            totalTaxes = tax1 + tax2 + tax3;
            //Spelprocessen körs tre gånger till, en för varje stad, spelaren får reda på gladhet och behov och skriver hur mycket pengar varje stad får
            //Denna gången får däremot stad 3 pest och gladheten går ner och behovet går upp
            
            e2.WriteInfo2(totalTaxes, stad1, stad2, stad3);

            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
           
           e1.BuildHouse(stad1, stad2, stad3);

            //Spelet är över
            System.Console.WriteLine("Tack för att du har spelat! Spelet är över.");

            System.Console.WriteLine("Tryck på vilken knapp som helst...");
            Console.ReadLine();
        }
    }
}
