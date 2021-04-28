using System;

namespace Slutprojekt
{
    public class Village: Subjects
    {
        private int hasTavern = 0;
        //Konstruktor som ger staden värdena av en by
        public Village()
        {
            needs = 2;

            population = 1;

            taxes = 3;
        }
        public void BuildTavern()
        {
            happiness += 3;
            hasTavern = 1;
        }
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
