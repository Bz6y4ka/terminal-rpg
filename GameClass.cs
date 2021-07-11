using System;
using System.Collections.Generic;
using System.Text;

namespace terminal_rpg
{
    public class GameClass
    {
        static int HandAttack = 0; 

        public GameClass(int HandAttack)
        {
             HandAttack = 1;
        }

        GameClass Dudu = new GameClass (HandAttack);
    }
}
