using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class Subjects
    {
        //Här är de variabler som används i klassen
        //Needs är hur mycket pengar varje stad/by/storstad behöver
        protected int needs;
        //Platsens namn
        private string name = "";
        //Hur glada stadens invånare är
        protected int happiness = 5;
        //Skatten man får från befolkningen
        protected int taxes;
        
        private Random generator = new Random();
        //Listor med namn och byggnader
        private List<string> names = new List<string>() {"Sharpton", "Aroonshire", "MillerVille", "Auchendinny", "Appleby", "Braedon", "Queenstown"};
       
        private List<string> buildings = new List<string>() {"Church", "Tavern", "Sewer"};
        //Konstruktor som ger staden sitt namn och happiness
        public Subjects()
        {
            int a = generator.Next(1,4);

            int happiness =+ a;

            int b = generator.Next(0,7);

            name = names[b];

        }
        //Metod för att hämta klassens namn
        public string GetName()
        {
            return name;
        }
        //Metoder för att hämta klassens skatt, behov och gladhet
        public int GetTaxes()
        {
            return taxes;
        }
        public int GetNeeds()
        {
            return needs;
        }
        public int GetHappiness()
        {
            return happiness;
        }
        //Metod som sänker gladheten
        public void TickHappiness()
        {
            happiness -= 2;
        }

        public void SetHappiness(int decrease)
        {
            happiness -= decrease;
            if(happiness < 0)
            {
                happiness = 0;
            }
        }
        public void IncreaseNeeds(int increase)
        {
            if(increase <= 0)
            {
                increase = 1;
            }
            needs += increase;
        }
    }
}
