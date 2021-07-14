using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class FrostMage : Mage
    {
        private const int STRONG_FROST_ATTACK /* боже, как пафосно */ = 30;
        private const int WEAK_FROST_ATTACK = 15;
        private int ManaInThisMoment = ManaPool;

        public void MageAttack()
        {
            if(ManaInThisMoment > 0)
            {
                if (ManaInThisMoment > 30)
                {
                    Console.WriteLine("Шквал");
                    ManaInThisMoment -= STRONG_FROST_ATTACK;
                }
                if (ManaInThisMoment < 30)
                {
                    Console.WriteLine("Ледяное копье");
                    ManaInThisMoment -= WEAK_FROST_ATTACK;
                }
            }
            else
            {
                Console.WriteLine(NO_ATTACK);
            }
        }

        public void MageSimpleAttack()
        {
            Console.WriteLine(MAGE_SIMPLE_ATTACK);
        }
    }
}
