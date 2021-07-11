using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    public class DuduGameClass
    {
        public int ConvokeTime = 100;
        public DuduGameClass( int ConvokeTime)
        {
            this.ConvokeTime = ConvokeTime;
        }

    }
    class FeralDudu
    {
        int StartEnergy = 0;
        int Shred = 20;
        int Bite;

        public FeralDudu(int StartEnergy, int Shred, int Bite)
        {
            this.StartEnergy = StartEnergy;
            this.Shred = Shred;
            this.Bite = Bite;
        }

        public void StartAttack(int ConvokeTime)
        {
            ConvokeTime = Shred * 16;
        }

        public void ShredAttack()
        {
            StartEnergy += Shred;
        }

        public void BiteAttack()
        {
            if (StartEnergy == 80)
            {
                Bite = 100;
            }
        }
    }

    class BoomieDudu
    {
        int MoonFireDamage = 1000;
        int MoonFire = 20;
        int StartManaPool = 100;

        public void StartAttack(int ConvokeTime)
        {
            ConvokeTime = MoonFireDamage * 16;
        }

        public void MoonFireAttck(int ConvokeTime)
        {
            StartManaPool -= MoonFire;
        }
    }
}
