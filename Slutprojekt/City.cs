using System;

namespace Slutprojekt
{
    public class City : Subjects
    {
        private int hasSewers = 0;
        //Konstruktor som ger staden värdena av en storstad
        public City()
        {
            needs = 4;

            population = 3;

            taxes = 5;
        }
        public void BuildSewers()
        {
            happiness += 3;
            hasSewers = 1;
        }
        public bool GetSewers()
        {
            if (hasSewers == 1)
            {
                return true;
            }
            return false;
        }
    }
}
