using System;

namespace Slutprojekt
{
    public class Event2 : Events
    {
        public void BuildHouse(Village s1,  Town s2, City s3)
        {
            Console.WriteLine("Nu kan du välja att bygga saker i städerna, att bygga något kostar 5 guld och ökar gladheten i staden med 3.");
            Console.WriteLine(s1.GetName() + " har en gladhet på " + s1.GetHappiness() + ", " + s1.GetName() + " har en gladhet på " + s2.GetHappiness() + " och " + s3.GetName() + " har en gladhet på "+ s3.GetHappiness() + ".");
            Console.WriteLine("I vilken stad vill du bygga?");
            Console.WriteLine("1. " + s1.GetName());
            Console.WriteLine("2. " + s2.GetName());
            Console.WriteLine("3. "+ s3.GetName());
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
                s1.BuildTavern();
                int thirdHappiness1 = s1.GetHappiness();
                Console.WriteLine(s1.GetName() + " har nu en gladhet på " + thirdHappiness1 + ".");
            }
            else if(d.Key == ConsoleKey.D2)
            {
                s2.BuildChurch();
                int thirdHappiness2 = s2.GetHappiness();
               
                Console.WriteLine(s2.GetName() + " har nu en gladhet på " + thirdHappiness2 + ".");
            }
            else if(d.Key == ConsoleKey.D3)
            {
                s3.BuildSewers();
                int thirdHappiness3 = s3.GetHappiness();
                Console.WriteLine(s3.GetName() + " har nu en gladhet på " + thirdHappiness3 + ".");
            }
            else if(d.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Spelet fortsätter.");
            }
        }
        public void WriteInfo2(int totalTaxes, Village a1, Town a2, City a3)
        {
            Console.WriteLine("Månad 2 börjar nu. Du har " + totalTaxes + " guld i din kista.");
            Console.WriteLine(a3.GetName() + " har drabbats av pesten! Stadens gladhet går ner med 3 och deras behov går upp med 2 denna månad!");

            a3.SetHappiness(3);
            a3.IncreaseNeeds(2);

            //Om gladheten i stad 3 blir noll så förlorar spelaren
            if(a3.GetHappiness() == 0)
            {
                System.Console.WriteLine(a3.GetName() + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
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

            Console.WriteLine(a1.GetName() + " har en gladhet på " + a1.GetHappiness() + " och ett behov av " + a1.GetNeeds() + " guld, hur mycket vill du betala dem?");
            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + a1.GetName() + " " + b + " guld.");

            if(b < a1.GetNeeds())
            {
                a1.TickHappiness();
            }

            int fifthHappiness1 = a1.GetHappiness();
            //Om gladheten blir för låg förlorar spelaren
            if(fifthHappiness1 <= 0)
            {
                System.Console.WriteLine(a1.GetName() + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                return;
            }
            
            Console.WriteLine(a1.GetName() + " har nu en gladhet på " + fifthHappiness1 + ".");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(a2.GetName() + " har en gladhet på " + a2.GetHappiness() + " och ett behov av " + a2.GetNeeds() + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + a2.GetName() + " " + b + " guld.");
            totalTaxes -= b;

            if(b < a2.GetNeeds())
            {
                a2.TickHappiness();
            }
            
            int fifthHappiness2 = a2.GetHappiness();

            if(fifthHappiness2 <= 0)
            {
                System.Console.WriteLine(a2.GetName() + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                System.Console.WriteLine("Tryck på vilken knapp som helst...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(a2.GetName() + " har nu en gladhet på " + a2.GetHappiness() + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(a3.GetName() + " har en gladhet på " + a3.GetHappiness() + " och ett behov av " + a3.GetNeeds() + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + a3.GetName() + " " + b + " guld.");
            totalTaxes -= b;

            if(b < a3.GetNeeds())
            {
                a3.TickHappiness();
            }
            
            
            int fifthHappiness3 = a3.GetHappiness();

            if(fifthHappiness3 == 0)
            {
                System.Console.WriteLine(a3.GetName() + "s gladhet har nått noll! De har startat ett uppror och många andra städer följer dem! Du har förlorat spelet.");
                return;
            }

            Console.WriteLine(a3.GetName() + " har nu en gladhet på " + a3.GetHappiness() + ", och du har " + totalTaxes + " guld i kistan.");
        }

    }
}
