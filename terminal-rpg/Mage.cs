using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class Mage : Player
    {

        public const int ATTACK = 1; 
        public const int ManaPool = 100;
        public int MAGE_SIMPLE_ATTACK = ManaPool - ATTACK;
        public const string NO_ATTACK = "Не могу атаковать";

    }
}
