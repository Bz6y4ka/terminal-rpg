using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class FeralDudu : Dudu
    {
        private int Start_Energy = 0;
        private const int SHRED = 20;
        private const string BITE = "Кус кус";

        public void StartAttack()
        {
            Console.WriteLine(Convoke);
        }

        public void ShredAttack()
        {
            Start_Energy += SHRED;
        }

        public void BiteAttack()
        {
            if(Start_Energy == 80)
            {
                Console.WriteLine(BITE);
            }
        }
    }
}
