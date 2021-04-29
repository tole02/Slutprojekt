using System;

namespace Slutprojekt
{
    public class Town: Subjects
    {
        //Variabel som används i en metod för att kolla ifall spelaren har byggt i staden
        private int hasChurch = 0;
        //Konstruktor som ger staden värdena av en stad
        public Town()
        {
            needs = 3;

            taxes = 4;
        }
        //Metod som körs när spelaren bygger i denna staden, då går gladheten upp och variabeln hasChurch blir 1
        public void BuildChurch()
        {
            happiness += 3;
            hasChurch = 1;
        }
        //Metod som kallas när spelet kollar ifall man byggt i denna stad, om variabeln hasChurch är 1 så returnerar den true, annars returnerar den false
        public bool GetChurch()
        {
            if (hasChurch == 1)
            {
                return true;
            }
            return false;
        }
    }
}
