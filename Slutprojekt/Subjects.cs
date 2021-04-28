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
        //Hur många människor som bor där, ju mer desto mer kostar det men desto fler skatter får man
        protected int population;
        //Hur glada stadens invånare är
        protected int happiness = 5;
        //Skatten man får från befolkningen
        protected int taxes;
        
        private Random generator = new Random();
        //Listor med namn och byggnader
        List<string> names = new List<string>() {"Sharpton", "Aroonshire", "MillerVille", "Auchendinny", "Appleby", "Braedon", "Queenstown"};
       
        List<string> buildings = new List<string>() {"Church", "Tavern", "Sewer"};
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
        
    }
}
