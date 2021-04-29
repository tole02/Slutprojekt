using System;

namespace Slutprojekt
{
    public class City : Subjects
    {
        //Samma som i Town.cs
        private int hasSewers = 0;
        //Konstruktor som ger staden värdena av en storstad
        public City()
        {
            needs = 4;

            taxes = 5;
        }
        //Samma som i Town.cs, spelaren kan bygga och gladhet går upp
        public void BuildSewers()
        {
            happiness += 3;
            hasSewers = 1;
        }
        //Samma som i Town.cs, körs för att kolla om spelaren har byggt
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
