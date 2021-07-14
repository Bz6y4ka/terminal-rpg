using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class MoonkinDudu : Dudu
    {
        private int START_MANA = 100;
        private const int MOON_FIRE = 20;

        public void StartAttack()
        {
            Console.WriteLine(Convoke);
        }

        public void MoonFireAttack()
        {
            START_MANA -= MOON_FIRE;
        }
    }
}
