using System;

namespace Slutprojekt
{
    public class Village: Subjects
    {
        //Samma som i Town.cs
        private int hasTavern = 0;
        //Konstruktor som ger staden värdena av en by
        public Village()
        {
            needs = 2;

            taxes = 3;
        }
        //Samma som i Town.cs, spelaren kan bygga och gladhet går upp
        public void BuildTavern()
        {
            happiness += 3;
            hasTavern = 1;
        }
        //Samma som i Town.cs, körs för att kolla om spelaren har byggt
        public bool GetTavern()
        {
            if (hasTavern == 1)
            {
                return true;
            }
            return false;
        }
    }
}
