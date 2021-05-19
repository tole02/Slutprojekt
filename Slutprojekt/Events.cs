using System;

namespace Slutprojekt
{
    public class Events
    {
        protected string a = Console.ReadLine();

        protected int b = 0;

        public Events()
        {
            Int32.TryParse(a, out b);
        }
        public void WriteInfo(int totalTaxes, Village t1, Town t2, City t3)
        {
            Console.WriteLine("Månad 1 börjar nu. Du har " + totalTaxes + " guld i din skattkista.");
            Console.WriteLine(t1.GetName() + " har en gladhet på " + t1.GetHappiness() + " och ett behov av " + t1.GetNeeds() + " guld, hur mycket vill du betala dem?");
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
            Console.WriteLine("Du betalar " + t1.GetName() + " " + b + " guld.");
            //Om svaret spelaren skrev är mindre än stadens behov så går stadens gladhet ner
            if(b < t1.GetNeeds())
            {
                t1.TickHappiness();
            }
            //Gladheten samlas in igen och berättas för spelaren
            int secondHappiness1 = t1.GetHappiness();
            
            Console.WriteLine(t1.GetName() + " har nu en gladhet på " + secondHappiness1 + ".");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Här upprepas exakt samma process för stad 2
            Console.WriteLine(t2.GetName() + " har en gladhet på " + t2.GetHappiness() + " och ett behov av " + t2.GetNeeds() + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + t2.GetName() + " " + b + " guld.");
            totalTaxes -= b;

            if(b < t2.GetNeeds())
            {
                t2.TickHappiness();
            }
            
            int secondHappiness2 = t2.GetHappiness();

            Console.WriteLine(t2.GetName() + " har nu en gladhet på " + secondHappiness2 + ", och du har " + totalTaxes + " guld i kistan.");
            Console.WriteLine("Tryck på vilken knapp som helst...");

            Console.ReadKey();

            Console.Clear();
            //Och här upprepas den för stad 3
            Console.WriteLine(t3.GetName() + " har en gladhet på " + t3.GetHappiness() + " och ett behov av " + t3.GetNeeds() + " guld, hur mycket vill du betala dem?");

            a = Console.ReadLine();
            b = 0;
            Int32.TryParse(a, out b);

            while(b < 0 || b >= totalTaxes)
            {
                Console.WriteLine("Du måste ange en siffra mellan 0 och max av din skattkista.");
                a = Console.ReadLine();
                b = int.Parse(a);
            }
            Console.WriteLine("Du betalar " + t3.GetName() + " " + b + " guld.");
            totalTaxes -= b;

            if(b < t3.GetNeeds())
            {
                t3.TickHappiness();
            }
            
            int secondHappiness3 = t3.GetHappiness();

            Console.WriteLine(t3.GetName() + " har nu en gladhet på " + secondHappiness3 + ", och du har " + totalTaxes + " guld i kistan.");
        }



    }
}
