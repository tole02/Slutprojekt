using System;

namespace Slutprojekt
{
    public class Towns: Subjects
    {
        private int hasChurch = 0;
        //Konstruktor som ger staden värdena av en stad
        public Towns()
        {
            needs = 3;

            population = 2;

            taxes = 4;
        }
        public void BuildChurch()
        {
            happiness += 3;
            hasChurch = 1;
        }
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
