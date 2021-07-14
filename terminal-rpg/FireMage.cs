using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    class FireMage : Mage
    {
        private const int STRONG_FIRE_ATTACK /* боже, как пафосно */ = 40;
        private const int WEAK_FIRE_ATTACK = 10;
        private int ManaInThisMoment = ManaPool;

        public void MageAttack()
        {
            if (ManaInThisMoment > 0)
            {
                if (ManaInThisMoment > 40)
                {
                    Console.WriteLine("ПИДОРБЛААААСТ");
                    ManaInThisMoment -= STRONG_FIRE_ATTACK;
                }
                if (ManaInThisMoment < 40)
                {
                    Console.WriteLine("ОБЖОГ");
                    ManaInThisMoment -= WEAK_FIRE_ATTACK;
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
