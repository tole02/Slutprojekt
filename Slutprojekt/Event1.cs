using System;

namespace Slutprojekt
{
    public class Event1 : Events
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
    }
}
