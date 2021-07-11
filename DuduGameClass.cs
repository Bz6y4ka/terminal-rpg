using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    public class DuduGameClass // переименовать в Dudu
    {
        public int ConvokeTime = 100; // сделать константой, константы ПИШУТСЯ_В_ТАКОМ_КЕЙСЕ и сделать ее private, String
        public DuduGameClass( int ConvokeTime)
        {
            this.ConvokeTime = ConvokeTime; // лишнее
        }

    }
    class FeralDudu // вынести в отдельный класс - отнаследовать от друида
    {
        int StartEnergy = 0; // private
        int Shred = 20; // private и константа
        int Bite; // to String, константа = 'Укус'

        public FeralDudu(int StartEnergy, int Shred, int Bite)
        {
            this.StartEnergy = StartEnergy; // инициализируется внутри класса
            this.Shred = Shred; // константа - не инициализируется
            this.Bite = Bite; 
        }

        public void StartAttack(int ConvokeTime)
        {
            ConvokeTime = Shred * 16; // 16 в константу
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

    class BoomieDudu // отдельный класс
    {
        // константы MOON_FIRE_DAMAGE
        int MoonFireDamage = 1000;
        int MoonFire = 20;
        int StartManaPool = 100;

        public void StartAttack(int ConvokeTime)
        {
            ConvokeTime = MoonFireDamage * 16;
        }

        public void MoonFireAttck(int ConvokeTime) // поправить очепятку
        {
            StartManaPool -= MoonFire; // что будет, если мы уйдет за 0?
        }
    }
}
