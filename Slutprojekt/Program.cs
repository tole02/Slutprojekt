using System;
using System.Threading;

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

            Town stad2 = new Town();

            City stad3 = new City();
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
            Console.WriteLine("Månad 1 börjar nu. Du har " + totalTaxes + " guld i din skattkista.");
            Console.WriteLine(name1 + " har en gladhet på " + happiness1 + " och ett behov av " + needs1 + " guld, hur mycket vill du betala dem?");
            string a = Console.ReadLine();
            int b = 0;
            Int32.TryParse(a, out b);
            //Loopen kollar ifall spelarens svar är ogiltigt och ber spelaren skriva igen
            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name1 + " " + b + " guld.");
            //Om svaret spelaren skrev är mindre än stadens behov så går stadens gladhet ner
            if(b < needs1)
            {
                stad1.TickHappiness();
            }
            //Gladheten samlas in igen och berättas för spelaren
            int secondHappiness1 = stad1.GetHappiness();
            
            Console.WriteLine(name1 + " har nu en gladhet på " + secondHappiness1 + ".");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Här upprepas exakt samma process för stad 2
            Console.WriteLine(name2 + " har en gladhet på " + happiness2 + " och ett behov av " + needs2 + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name2 + " " + b + " guld.");
            totalTaxes -= b;

            if(b < needs2)
            {
                stad2.TickHappiness();
            }
            
            int secondHappiness2 = stad2.GetHappiness();

            Console.WriteLine(name1 + " har nu en gladhet på " + secondHappiness2 + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Och här upprepas den för stad 3
            Console.WriteLine(name3 + " har en gladhet på " + happiness3 + " och ett behov av " + needs3 + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name3 + " " + b + " guld.");
            totalTaxes -= b;

            if(b < needs3)
            {
                stad3.TickHappiness();
            }
            
            int secondHappiness3 = stad3.GetHappiness();

            Console.WriteLine(name3 + " har nu en gladhet på " + secondHappiness3 + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Spelaren kan bestämma om den vill bygga något i en av städerna, detta ökar stadens gladhet och kostar 5 guld
            Console.WriteLine("Nu kan du välja att bygga saker i städerna, att bygga något kostar 5 guld och ökar gladheten i staden med 3.");
            Console.WriteLine(name1 + " har en gladhet på " + secondHappiness1 + ", " + name2 + " har en gladhet på " + secondHappiness2 + " och " + name3 + " har en gladhet på "+ secondHappiness3 + ".");
            Console.WriteLine("I vilken stad vill du bygga?");
            Console.WriteLine("1. " + name1);
            Console.WriteLine("2. " + name2);
            Console.WriteLine("3. "+ name3);
            Console.WriteLine("4. Ingen");

            ConsoleKeyInfo d = Console.ReadKey();
            //Loopen kollar ifall spelaren trycker ner en felaktig tangent och säger till
            while(d.Key != ConsoleKey.D1 && d.Key != ConsoleKey.D2 && d.Key != ConsoleKey.D3 && d.Key != ConsoleKey.D4)
            {
                Console.WriteLine("Du måste trycka på en knapp mellan 1 och 4!");
                d = Console.ReadKey();    
            }    
            //Om spelaren trycker 1 så bygger den i den första staden, 2 så bygger den i den andra osv.
            if(d.Key == ConsoleKey.D1)
            {
                stad1.BuildTavern();
                int thirdHappiness1 = stad1.GetHappiness();
                Console.WriteLine(name1 + " har nu en gladhet på " + thirdHappiness1 + ".");
            }
            else if(d.Key == ConsoleKey.D2)
            {
                stad2.BuildChurch();
                int thirdHappiness2 = stad2.GetHappiness();
               
                Console.WriteLine(name2 + " har nu en gladhet på " + thirdHappiness2 + ".");
            }
            else if(d.Key == ConsoleKey.D3)
            {
                stad3.BuildSewers();
                int thirdHappiness3 = stad3.GetHappiness();
                Console.WriteLine(name3 + " har nu en gladhet på " + thirdHappiness3 + ".");
            }
            else if(d.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Spelet fortsätter.");
            }
            //Gladheten samlas in igen då den kan ha blivit uppdaterad av att spelaren byggde i en av städerna
            int fourthHappiness1 = stad1.GetHappiness();
            int fourthHappiness2 = stad2.GetHappiness();
            int fourthHappiness3 = stad3.GetHappiness();
            //Skattkistan återfylls
            totalTaxes = tax1 + tax2 + tax3;
            //Spelprocessen körs tre gånger till, en för varje stad, spelaren får reda på gladhet och behov och skriver hur mycket pengar varje stad får
            //Denna gången får däremot stad 3 pest och gladheten går ner och behovet går upp
            Console.WriteLine("Månad 2 börjar nu. Du har " + totalTaxes + " guld i din kista.");
            Console.WriteLine(name3 + " har drabbats av pesten! Stadens gladhet går ner med 3 och deras behov går upp med 2 denna månad!");

            needs3 += 2;    
            fourthHappiness3 -= 3;
            //Om gladheten i stad 3 blir noll så förlorar spelaren
            if(fourthHappiness3 == 0)
            {
                System.Console.WriteLine(name3 + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                System.Console.WriteLine("Var spelet roligt? (JA/NEJ)");
                string input = Console.ReadLine();
                //Loopen kollar så spelaren skriver rätt
                while(input != "ja" && input != "nej" && input != "Ja" && input != "Nej")
                {
                    System.Console.WriteLine("Svara ja eller nej!");
                    input = Console.ReadLine();
                }
                //Spelet stängs ner
                if(input == "ja" && input == "Ja" && input == "nej" && input == "Nej")
                {
                    return;
                }
                return;
            }

            Console.WriteLine(name1 + " har en gladhet på " + fourthHappiness1 + " och ett behov av " + needs1 + " guld, hur mycket vill du betala dem?");
            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name1 + " " + b + " guld.");

            if(b < needs1)
            {
                stad1.TickHappiness();
            }

            int fifthHappiness1 = stad1.GetHappiness();
            //Om gladheten blir för låg förlorar spelaren
            if(fifthHappiness1 <= 0)
            {
                System.Console.WriteLine(name1 + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                return;
            }
            
            Console.WriteLine(name1 + " har nu en gladhet på " + fifthHappiness1 + ".");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(name2 + " har en gladhet på " + fourthHappiness2 + " och ett behov av " + needs2 + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name2 + " " + b + " guld.");
            totalTaxes -= b;

            if(b < needs2)
            {
                stad2.TickHappiness();
            }
            
            int fifthHappiness2 = stad2.GetHappiness();

            if(fifthHappiness2 <= 0)
            {
                System.Console.WriteLine(name2 + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                System.Console.WriteLine("Tryck på vilken knapp som helst...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(name3 + " har nu en gladhet på " + fifthHappiness2 + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(name3 + " har en gladhet på " + fourthHappiness3 + " och ett behov av " + needs3 + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + name3 + " " + b + " guld.");
            totalTaxes -= b;

            if(b < needs3)
            {
                stad3.TickHappiness();
            }
            
            
            int fifthHappiness3 = stad3.GetHappiness();

            if(fifthHappiness3 == 0)
            {
                System.Console.WriteLine(name3 + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                return;
            }

            Console.WriteLine(name1 + " har nu en gladhet på " + fifthHappiness3 + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Spelaren kan bygga igen
            Console.WriteLine("Nu kan du välja att bygga saker i städerna, att bygga något kostar 5 guld och ökar gladheten i staden med 3.");
            Console.WriteLine(name1 + " har en gladhet på " + fifthHappiness1 + ", " + name2 + " har en gladhet på " + fifthHappiness2 + " och " + name3 + " har en gladhet på "+ fifthHappiness3 + ".");
            Console.WriteLine("I vilken stad vill du bygga?");
            Console.WriteLine("1. " + name1);
            Console.WriteLine("2. " + name2);
            Console.WriteLine("3. "+ name3);
            Console.WriteLine("4. Ingen");

            d = Console.ReadKey();

            bool hasTavern = stad1.GetTavern();
            bool hasChurch = stad2.GetChurch();
            bool hasSewers = stad3.GetSewers();

            while(d.Key != ConsoleKey.D1 && d.Key != ConsoleKey.D2 && d.Key != ConsoleKey.D3 && d.Key != ConsoleKey.D4)
            {
                Console.WriteLine("Du måste trycka på en knapp mellan 1 och 4!");
                d = Console.ReadKey();    
            }    

            if(d.Key == ConsoleKey.D1)
            {
                if(hasTavern == true)
                {
                    System.Console.WriteLine("Du kan inte bygga mer i den här staden!");
                }
                else if(hasTavern == false)
                {
                    stad1.BuildTavern();
                    int sixthHappiness1 = stad1.GetHappiness();
                    Console.WriteLine(name1 + " har nu en gladhet på " + sixthHappiness1 + ".");
                }
                
            }
            else if(d.Key == ConsoleKey.D2)
            {
                if(hasChurch == true)
                {
                    System.Console.WriteLine("Du kan inte bygga mer i den här staden!");
                }
                else if(hasChurch == false)
                {
                    stad2.BuildChurch();
                    int sixthHappiness2 = stad2.GetHappiness();
               
                    Console.WriteLine(name2 + " har nu en gladhet på " + sixthHappiness2 + ".");
                }   
            }
            else if(d.Key == ConsoleKey.D3)
            {
                if(hasSewers == true)
                {
                    System.Console.WriteLine("Du kan inte bygga mer i den här staden!");
                }
                else if(hasSewers == false)
                {
                    stad3.BuildSewers();
                    int sixthHappiness3 = stad3.GetHappiness();
                    Console.WriteLine(name3 + " har nu en gladhet på " + sixthHappiness3 + ".");
                }
            }
            else if(d.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Spelet fortsätter.");
            }
            //Spelet är över
            System.Console.WriteLine("Tack för att du har spelat! Spelet är över.");

            System.Console.WriteLine("Tryck på vilken knapp som helst...");
            Console.ReadLine();
        }
    }
}
